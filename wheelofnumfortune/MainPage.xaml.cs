using System.Net.Sockets;
using System.Text;

namespace wheelofnumfortune;

public partial class MainPage : ContentPage
{
    private HttpClient client = new HttpClient();
    private HttpResponseMessage httpResponse;
    private String risposta;
    private String visualizzazione;
    private int i;
    private StringBuilder sb;
    private Random random;
    public MainPage()
    {
        random = new Random();
        InitializeComponent();
        tick();
    }

    private async void tick()
    {
        lblStatus.Text = "";
        txtSolution.Text = "";
        try
        {
            httpResponse = await client.GetAsync("https://helloacm.com/api/fortune/");
            if (httpResponse.IsSuccessStatusCode)
            {
                risposta = await httpResponse.Content.ReadAsStringAsync();
            }
        }
        catch (InvalidOperationException ex)
        {
            lblStatus.Text = ex.Message;
            txtSolution.IsEnabled = false;
            btnDiscover.IsEnabled = false;
            btnCheck.IsEnabled = false;
            return;
        }
        catch (HttpRequestException ex)
        {
            lblStatus.Text = ex.Message;
            txtSolution.IsEnabled = false;
            btnDiscover.IsEnabled = false;
            btnCheck.IsEnabled = false;
            return;
        }
        catch (SocketException ex)
        {
            lblStatus.Text = ex.Message;
            txtSolution.IsEnabled = false;
            btnDiscover.IsEnabled = false;
            btnCheck.IsEnabled = false;
            return;
        }
        if (risposta!=null)
        {
           
            risposta = risposta.Substring(1, risposta.Length - 2);
#if WINDOWS
            risposta = risposta.Replace("\\n", "\r");
#else
            risposta = risposta.Replace("\\n", "\n");
#endif
            risposta = risposta.Replace("\\t", "    ");
            risposta = risposta.Replace("\\b", "");
            risposta = risposta.Replace("\\\"", "\"");
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
            txtSolution.IsEnabled = true;
            btnDiscover.IsEnabled = true;
            btnCheck.IsEnabled = true;
        }
        else
        {
            lblStatus.Text = $"The HTTP status code is ${httpResponse.StatusCode}";
            txtSolution.IsEnabled = false;
            btnDiscover.IsEnabled = false;
            btnCheck.IsEnabled = false;
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
        if (visualizzazione.IndexOf('*') == -1)
        {
            lblStatus.Text = "You lost";
            txtSolution.IsEnabled = false;
            btnDiscover.IsEnabled = false;
            btnCheck.IsEnabled = false;
        }
    }
}
