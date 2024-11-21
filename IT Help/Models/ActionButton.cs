
using System.Diagnostics;

namespace IT_Help.Models
{
    internal class ActionButton
    {
        public string Label { get; set; }
        public string Link { get; set; }
        public string Command { get; set; }

        private Task DoCommand()
        {
            Process.Start(Link);

            return Task.CompletedTask;
        }

        private Task OpenLink()
        {
            if (!Link.Contains("http"))
                Link = $"https://{Link}";

            Process.Start(Link);

            return Task.CompletedTask;
        }

        public async void Clicked()
        {
            try
            {
                if (!string.IsNullOrEmpty(Link))
                {
                    await OpenLink();
                }

                if (!string.IsNullOrEmpty(Command))
                {
                    await DoCommand();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}