using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Diagnostics;
using LCUSharp;

// TODO: INVESIGATE POST CALLS WHEN CREATING A LOBBY OR ADDING A BOT. LANE CHANGES ARE DIFFERENT AND IT DOESNT EXIST IN LOBBY/v2 ITS INSEAD IN 
// TEAMBUILDER OR SMTH IDFK 31.07.2024 I guess i figured it out lol oh yea for the future devs its just in normal bot settings btw it's called
// position and thats it

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public class Lobby // unusued 
        {
            public string lobbyName { get; set; }
            public string lobbyPassword { get; set; }
        }

        public class Champion
        {
            public int championId { get; set; }
            public string Name { get; set; }
            public string position { get; set; }
        }

        public class BotSettings // UNUSED
        {
            public int championId { get; set; }
            public string Difficulty { get; set; }
            public string Lane { get; set; }
        }

        public class BotLayout
        {
            public int championId { get; set; }
            public string position { get; set; }
        }

        private readonly string configFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WindowsFormsApp1", "layout.json");

        public Form1()
        {
            InitializeComponent();
            LoadLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadChampions(summoner2);   // LOAD AVAILABLE BOTS
            LoadChampions(summoner3);
            LoadChampions(summoner4);
            LoadChampions(summoner5);
            LoadChampions(summoner6);
            LoadChampions(summoner7);
            LoadChampions(summoner8);
            LoadChampions(summoner9);
            LoadChampions(summoner10);

            LoadPositions(summoner2lane);   // LOAD POSITIONS
            LoadPositions(summoner3lane);
            LoadPositions(summoner4lane);
            LoadPositions(summoner5lane);
            LoadPositions(summoner6lane);
            LoadPositions(summoner7lane);
            LoadPositions(summoner8lane);
            LoadPositions(summoner9lane);
            LoadPositions(summoner10lane);

            LoadDifficulties(summoner2diff); // LOAD DIFFICULTIES
            LoadDifficulties(summoner3diff);
            LoadDifficulties(summoner4diff);
            LoadDifficulties(summoner5diff);
            LoadDifficulties(summoner6diff);
            LoadDifficulties(summoner7diff);
            LoadDifficulties(summoner8diff);
            LoadDifficulties(summoner9diff);
            LoadDifficulties(summoner10diff);

            LoadLayout(); // LOAD MOST RECENT LAYOUT

            // TODO: Add a null value so the user can create lobbies without bots 27.02.2024 DONE
        }

        private void SaveLayout()
        {
            var layout = new List<BotLayout>
            {
                new BotLayout { championId = (int)summoner2.SelectedValue, position = summoner2lane.SelectedItem.ToString() },
                new BotLayout { championId = (int)summoner3.SelectedValue, position = summoner3lane.SelectedItem.ToString() },
                new BotLayout { championId = (int)summoner4.SelectedValue, position = summoner4lane.SelectedItem.ToString() },
                new BotLayout { championId = (int)summoner5.SelectedValue, position = summoner5lane.SelectedItem.ToString() },
                new BotLayout { championId = (int)summoner6.SelectedValue, position = summoner6lane.SelectedItem.ToString() },
                new BotLayout { championId = (int)summoner7.SelectedValue, position = summoner7lane.SelectedItem.ToString() },
                new BotLayout { championId = (int)summoner8.SelectedValue, position = summoner8lane.SelectedItem.ToString() },
                new BotLayout { championId = (int)summoner9.SelectedValue, position = summoner9lane.SelectedItem.ToString() },
                new BotLayout { championId = (int)summoner10.SelectedValue, position = summoner10lane.SelectedItem.ToString() }
            };
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(layout);
            Directory.CreateDirectory(Path.GetDirectoryName(configFilePath));
            File.WriteAllText(configFilePath, json);
        }

        private void LoadLayout()
        {
            if (!File.Exists(configFilePath))
                return;

            var json = File.ReadAllText(configFilePath);
            var layout = Newtonsoft.Json.JsonConvert.DeserializeObject<List<BotLayout>>(json);

            if (layout != null && layout.Count == 9)
            {
                summoner2.SelectedValue = layout[0].championId;
                summoner2lane.SelectedItem = layout[0].position;
                summoner3.SelectedValue = layout[1].championId;
                summoner3lane.SelectedItem = layout[1].position;
                summoner4.SelectedValue = layout[2].championId;
                summoner4lane.SelectedItem = layout[2].position;
                summoner5.SelectedValue = layout[3].championId;
                summoner5lane.SelectedItem = layout[3].position;
                summoner6.SelectedValue = layout[4].championId;
                summoner6lane.SelectedItem = layout[4].position;
                summoner7.SelectedValue = layout[5].championId;
                summoner7lane.SelectedItem = layout[5].position;
                summoner8.SelectedValue = layout[6].championId;
                summoner8lane.SelectedItem = layout[6].position;
                summoner9.SelectedValue = layout[7].championId;
                summoner9lane.SelectedItem = layout[7].position;
                summoner10.SelectedValue = layout[8].championId;
                summoner10lane.SelectedItem = layout[8].position;
            }
        }

        private void LogInfo(string message)
        {
            Console.WriteLine("INFO: " + message);
        }

        private void LogError(string message)
        {
            Console.WriteLine("ERROR: " + message);
        }

        private void LoadPositions (ComboBox comboBox)
        {
            var positions = new List<string> { " ", "TOP", "JUNGLE", "MIDDLE", "BOTTOM", "UTILITY" };
            comboBox.DataSource = positions;
        }

        private void LoadDifficulties (ComboBox comboBox)
        {
            var difficulty = new List<string> { "RSINTERMEDIATE", "RSBEGINNER", "RSINTRO" };
            comboBox.DataSource = difficulty;
        }

        private async Task<Tuple<int, int>> GetFreeSlots(LeagueClientApi api)
        {
            var response = await api.RequestHandler.GetJsonResponseAsync(HttpMethod.Get, "/lol-lobby/v2/lobby");
            var gameConfig = JObject.Parse(response)["gameConfig"];
            int team100 = 5 - gameConfig["customTeam100"].Count();
            int team200 = 5 - gameConfig["customTeam200"].Count();
            return new Tuple<int, int>(team100, team200);
        }

        private async Task<JArray> GetAvailableBots(LeagueClientApi api)
        {
            var response = await api.RequestHandler.GetJsonResponseAsync(HttpMethod.Get, "/lol-lobby/v2/lobby/custom/available-bots");
            return JArray.Parse(response);
        }

        // NOTE: Difficulty post calls are botDifficulty: "RSINTRO", "RSBEGINNER", "RSINTERMEDIATE" tag for search: DIFFICULTY POST CALL, DIFFICULTY,  
        /* NOTE: Lane post calls are like this: TOP, JUNGLE, MIDDLE, BOTTOM, UTILITY(what the fuck is utility cuh), there's also no way to find recommended lane for bots
          - First problem is that if we create a bot and we assign them on a different role (e.g Cho'Gath Pos: BOTTOM) the bot just doesn't know
          how to play that role so he will just stay in fountain instead. You could maybe put a warning for the user to not use a different role and just
          put recommended roles manually in the <Champion> List 31.07.2024 i think you can just pull recommended bot position just by using available 
          bots post call i think it shows which position they can play
         */
        private void LoadChampions(ComboBox comboBox)
        {
            var champions = new List<Champion>
            {
                new Champion { championId = 0,  Name = "Empty" },
                new Champion { championId = 84, position="MIDDLE", Name = "Akali" },
                new Champion { championId = 103, position="MIDDLE", Name = "Ahri" },
                new Champion { championId = 12, position="UTILITY", Name = "Alistar" },
                new Champion { championId = 32, position="JUNGLE", Name = "Amumu" },
                new Champion { championId = 1, position="MIDDLE",Name = "Annie" },
                new Champion { championId = 22, position="BOTTOM", Name = "Ashe" },
                new Champion { championId = 53, position="UTILITY", Name = "Blitzcrank" },
                new Champion { championId = 201, position="UTILITY", Name = "Braum" },
                new Champion { championId = 51, position="BOTTOM", Name = "Caitlyn" },
                new Champion { championId = 69, position = "MIDDLE", Name = "Cassiopeia" },
                new Champion { championId = 31, position = "TOP", Name = "Cho'Gath" },
                new Champion { championId = 122, position="TOP", Name = "Darius" },
                new Champion { championId = 131, position="JUNGLE", Name = "Diana" },
                new Champion { championId = 105, position = "MIDDLE", Name = "Fizz" },
                new Champion { championId = 3, position="UTILITY", Name = "Galio" },
                new Champion { championId = 86, position="TOP", Name = "Garen" },
                new Champion { championId = 120, position="JUNGLE", Name = "Hecarim" },
                new Champion { championId = 39, position = "TOP", Name = "Irelia" },
                new Champion { championId = 145, position="BOTTOM", Name = "Kai'Sa" },
                new Champion { championId = 38, position="MIDDLE", Name = "Kassadin" },
                new Champion { championId = 85, position="TOP", Name = "Kennen" },
                new Champion { championId = 121, position="JUNGLE", Name = "Kha'Zix" },
                new Champion { championId = 89, position = "UTILITY", Name = "Leona" },
                new Champion { championId = 876, position="JUNGLE", Name = "Lillia" },
                new Champion { championId = 127, position="MIDDLE", Name = "Lissandra" },
                new Champion { championId = 236, position="BOTTOM", Name = "Lucian" },
                new Champion { championId = 117, position="UTILITY", Name = "Lulu" },
                new Champion { championId = 99, position="MIDDLE", Name = "Lux" },
                new Champion { championId = 54, position="TOP", Name = "Malphite" },
                new Champion { championId = 57, position="JUNGLE", Name = "Maokai" },
                new Champion { championId = 11, position = "JUNGLE", Name = "Master Yi" },
                new Champion { championId = 902, position="UTILITY", Name = "Milio" },
                new Champion { championId = 21, position="BOTTOM", Name = "Miss Fortune" },
                new Champion { championId = 82, position="TOP", Name = "Mordekaiser" },
                new Champion { championId = 75, position="TOP",  Name = "Nasus" },
                new Champion { championId = 111, position="UTILITY", Name = "Nautilus" },
                new Champion { championId = 56, Name = "Nocturne" },
                new Champion { championId = 78, position="TOP",  Name = "Poppy" },
                new Champion { championId = 497, position="UTILITY", Name = "Rakan" },
                new Champion { championId = 888, position="UTILITY", Name = "Renata Glasc" },
                new Champion { championId = 68,  position="TOP",  Name = "Rumble" },
                new Champion { championId = 113, Name = "Sejuani" },
                new Champion { championId = 147, position="UTILITY", Name = "Seraphine" },
                new Champion { championId = 875, position="TOP",  Name = "Sett" },
                new Champion { championId = 102, Name = "Shyvana" },
                new Champion { championId = 15, Name = "Sivir" },
                new Champion { championId = 897,  position="BOTTOM",  Name = "Smolder" },
                new Champion { championId = 37, position="UTILITY", Name = "Sona" },
                new Champion { championId = 16, position="UTILITY", Name = "Soraka" },
                new Champion { championId = 44, position="UTILITY", Name = "Taric" },
                new Champion { championId = 18, Name = "Tristana" },
                new Champion { championId = 23, position="TOP",  Name = "Tryndamere" },
                new Champion { championId = 4, Name = "Twisted Fate" },
                new Champion { championId = 29, Name = "Twitch" },
                new Champion { championId = 6, position="TOP",  Name = "Urgot" },
                new Champion { championId = 110, Name = "Varus" },
                new Champion { championId = 67, Name = "Vayne" },
                new Champion { championId = 45, Name = "Veigar" },
                new Champion { championId = 711, Name = "Vex" },
                new Champion { championId = 254, Name = "Vi" },
                new Champion { championId = 112, Name = "Viktor" },
                new Champion { championId = 106, position="TOP",  Name = "Volibear" },
                new Champion { championId = 19, Name = "Warwick" },
                new Champion { championId = 62, position="TOP",  Name = "Wukong" },
                new Champion { championId = 5, Name = "Xin Zhao" },
                new Champion { championId = 83, position="TOP",  Name = "Yorick" },
                new Champion { championId = 115, Name = "Ziggs" },
                new Champion { championId = 143, position="UTILITY", Name = "Zyra" }
            };
            comboBox.DisplayMember = "Name";
            comboBox.ValueMember = "championId";
            comboBox.DataSource = champions;
        }
        private async Task AddBot(LeagueClientApi api, int teamId, int championId, string position, string botDifficulty = "RSINTERMEDIATE")
        {
            var data = new
            {
                botDifficulty = botDifficulty, // Corrected parameter name
                championId = championId,
                teamId = teamId.ToString(),
                position = position
            };

            var queryParameters = Enumerable.Empty<string>();

            try
            {
                var response = await api.RequestHandler.SendJsonRequestAsync(HttpMethod.Post, "/lol-lobby/v1/lobby/custom/bots", queryParameters, data);
                if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                {
                    LogInfo("Bot added");
                }
                else
                {
                    LogError("Failed to add bot");
                }
            }
            catch (Exception ex)
            {
                LogError(ex.Message);
            }
        }




        private Champion GetBotFromComboBox(ComboBox comboBox)
        {
            var selectedChampion = comboBox.SelectedItem as Champion;
            if (selectedChampion != null && selectedChampion.championId == 0) // Check for Empty value
            {
                return null;
            }
            return selectedChampion;
        }


        private void LogError(string message, string solution = "")
        {
            string logPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "WindowsFormsApp1", "error.log");
            Directory.CreateDirectory(Path.GetDirectoryName(logPath));

            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
                if (!string.IsNullOrEmpty(solution))
                {
                    writer.WriteLine($"Solution: {solution}");
                }
            }
        }


        private async void createLobbyBtn_Click(object sender, EventArgs e)
        {
            var api = await LeagueClientApi.ConnectAsync();

            string request = @"{
                customGameLobby: {
                    configuration: {
                        gameMode: 'PRACTICETOOL',
                        gameMutator: '',
                        mapId: 11,
                        mutators: {
                            id: 1
                        },
                        spectatorPolicy: 'NotAllowed',
                        teamSize: 5
                    },
                    lobbyName: '" + lobbyName.Text + @"',
                    lobbyPassword: '" + lobbyPwd.Text + @"'
                },
                isCustom: true
            }";
            JObject body = JObject.Parse(request);
            var queryParameters = Enumerable.Empty<string>();

            try
            {
                var response = await api.RequestHandler.SendJsonRequestAsync(HttpMethod.Post, "/lol-lobby/v2/lobby", queryParameters, body);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show("A lobby has been created", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await AddBotsToLobby(api);
                }
                else
                {
                    MessageBox.Show("An error has occurred! See error logs", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                LogError(ex.Message);
                MessageBox.Show("An error has occurred! See error logs", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private async Task AddBotsToLobby(LeagueClientApi api)
        {
            var freeSlots = await GetFreeSlots(api);
            var availableBots = await GetAvailableBots(api);

            int numBotsBlue = Math.Min(freeSlots.Item1, 5);
            int numBotsRed = Math.Min(freeSlots.Item2, 5);

            List<int> usedBots = new List<int>();

            var botComboboxes = new[] { summoner2, summoner3, summoner4, summoner5, summoner6, summoner7, summoner8, summoner9, summoner10 };
            var positionComboboxes = new[] { summoner2lane, summoner3lane, summoner4lane, summoner5lane, summoner6lane, summoner7lane, summoner8lane, summoner9lane, summoner10lane };
            var difficultyComboboxes = new[] { summoner2diff, summoner3diff, summoner4diff, summoner5diff, summoner6diff, summoner7diff, summoner8diff, summoner9diff, summoner10diff };

            for (int i = 0; i < botComboboxes.Length; i++)
            {
                var bot = GetBotFromComboBox(botComboboxes[i]);
                if (bot == null) continue; // Skip if no bot selected
                var position = positionComboboxes[i].SelectedItem.ToString();
                var botDifficulty = difficultyComboboxes[i].SelectedItem.ToString();
                if (string.IsNullOrEmpty(position)) position = bot.position; // Use default if no position selected
                int teamId = (i < 4) ? 100 : 200;
                await AddBot(api, teamId, bot.championId, position, botDifficulty); // Pass botDifficulty
                usedBots.Add(bot.championId);
            }
        }




        private void viewLogsBtn_Click(object sender, EventArgs e)
        {
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string logFilePath = Path.Combine(appDataPath, "LeagueLobbyCreator", "error.log");

            if (File.Exists(logFilePath))
            {
                string logContents = File.ReadAllText(logFilePath);
                MessageBox.Show(logContents, "Error Logs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No error logs found.", "Error Logs", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveLayout();
        }

        private void resetLayout_Click(object sender, EventArgs e)
        {
            summoner2.SelectedIndex = 0;
            summoner2lane.SelectedIndex = 0;
            summoner3.SelectedIndex = 0;
            summoner3lane.SelectedIndex = 0;
            summoner4.SelectedIndex = 0;
            summoner4lane.SelectedIndex = 0;
            summoner5.SelectedIndex = 0;
            summoner5lane.SelectedIndex = 0;
            summoner6.SelectedIndex = 0;
            summoner6lane.SelectedIndex = 0;
            summoner7.SelectedIndex = 0;
            summoner7lane.SelectedIndex = 0;
            summoner8.SelectedIndex = 0;
            summoner8lane.SelectedIndex = 0;
            summoner9.SelectedIndex = 0;
            summoner9lane.SelectedIndex = 0;
            summoner10.SelectedIndex = 0;
            summoner10lane.SelectedIndex = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/kaan1957");
        }
    }
}
