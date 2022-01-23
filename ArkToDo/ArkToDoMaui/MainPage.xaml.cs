﻿namespace ArkToDoMaui
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Currrent count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }
    }
}