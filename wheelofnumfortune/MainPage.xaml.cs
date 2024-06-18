using System.Text;

namespace wheelofnumfortune;

public partial class MainPage : ContentPage
{
    private static HttpClient client;
    private static HttpResponseMessage httpResponse;
    private static String risposta;
    private static String visualizzazione;
    private static int i;
    private static StringBuilder sb;
    private static Random random;
    public MainPage()
    {
        random = new Random();
        InitializeComponent();
        client = new HttpClient();
        tick();
    }

    private async void tick()
    {
        txtSolution.IsEnabled = true;
        btnDiscover.IsEnabled = true;
        btnCheck.IsEnabled = true;
        lblStatus.Text = "";
        try
        {
            httpResponse = await client.GetAsync("https://api.justyy.workers.dev/api/fortune");
        }
        catch (Exception ex)
        {
            lblFortune.Text = ex.Message;
            return;
        }

        if (httpResponse.IsSuccessStatusCode)
        {
            risposta = await httpResponse.Content.ReadAsStringAsync();
            risposta = risposta.Substring(1, risposta.Length - 2);
            risposta = risposta.Replace("\\n", "");
            risposta = risposta.Replace("\\t", " ");
            risposta = risposta.Replace("\\\"", "\"");
            while (risposta.IndexOf("  ") != -1)
                risposta = risposta.Replace("  ", " ");
            risposta = risposta.Trim();
            sb = new StringBuilder(risposta);
            for (i = 0; i < sb.Length; i++)
                switch (sb[i])
                {
                    case 'q':
                    case 'Q':
                    case 'w':
                    case 'W':
                    case 'e':
                    case 'E':
                    case 'r':
                    case 'R':
                    case 't':
                    case 'T':
                    case 'y':
                    case 'Y':
                    case 'u':
                    case 'U':
                    case 'i':
                    case 'I':
                    case 'o':
                    case 'O':
                    case 'p':
                    case 'P':
                    case 'a':
                    case 'A':
                    case 's':
                    case 'S':
                    case 'd':
                    case 'D':
                    case 'f':
                    case 'F':
                    case 'g':
                    case 'G':
                    case 'h':
                    case 'H':
                    case 'j':
                    case 'J':
                    case 'k':
                    case 'K':
                    case 'l':
                    case 'L':
                    case 'z':
                    case 'Z':
                    case 'x':
                    case 'X':
                    case 'c':
                    case 'C':
                    case 'v':
                    case 'V':
                    case 'b':
                    case 'B':
                    case 'n':
                    case 'N':
                    case 'm':
                    case 'M':
                        sb[i] = '*';
                        break;


                }
            visualizzazione = sb.ToString();
            lblFortune.Text = visualizzazione;
        }
        else
        {
            lblFortune.Text = $"The HTTP status code is ${httpResponse.StatusCode}";
        }

    }

    private void OnRefresh_Click(object sender, EventArgs e)
    {
        tick();
    }
    private void CheckSolution_Click(object sender, EventArgs e)
    {
        if (txtSolution.Text == risposta)
        {
            lblStatus.Text = "You are right";
            txtSolution.IsEnabled = false;
            btnDiscover.IsEnabled = false;
            btnCheck.IsEnabled = false;
        }
        else
        {
            lblStatus.Text = "You are wrong";
        }
    }

    private void DiscoverLetter_Click(object sender, EventArgs e)
    {
        lblStatus.Text = "";
        if (visualizzazione.IndexOf('*') == -1)
        {
            lblStatus.Text = "You lost";
            txtSolution.IsEnabled = false;
            btnDiscover.IsEnabled = false;
            btnCheck.IsEnabled = false;
            return;
        }
        i = random.Next(0, sb.Length);
        while (sb[i] != '*' && visualizzazione.IndexOf("*") != -1)
        {
            i++;
            if (i == sb.Length)
                i = 0;
        }
        sb[i] = risposta[i];
        visualizzazione = sb.ToString();
        lblFortune.Text = visualizzazione;
    }
}