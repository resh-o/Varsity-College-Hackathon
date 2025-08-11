namespace MusicSuggester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            cmbEmotion.Items.AddRange(new string[]
            {
                "Happy",
                "Sad",
                "Energetic",
                "Chill",
                "Romantic"
            });
            cmbEmotion.SelectedIndex = 0;
        }

        private void lbOutput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSuggest_Click(object sender, EventArgs e)
        {
            string mood = cmbEmotion.SelectedItem.ToString();
            string playlist = GetPlaylistForMood(mood);

            lbOutput.Items.Add($"Mood: {mood} → Playlist: {playlist}");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbOutput.Items.Clear();
        }
        private string GetPlaylistForMood(string mood)
        {
            return mood switch
            {
                "Happy" => "Good Vibes Only",
                "Sad" => "Feel Better Soon",
                "Energetic" => "Workout Playlist",
                "Chill" => "Lo-Fi Beats",
                "Romantic" => "Love Songs",
                _ => "No playlist found"
            };
        }
    }
}