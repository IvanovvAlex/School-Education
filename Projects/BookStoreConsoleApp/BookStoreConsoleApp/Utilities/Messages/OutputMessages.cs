namespace BookStoreConsoleApp.Utilities.Messages
{
    using System;

    public static class OutputMessages
    {
        public const string StartingMessage = "Type .help for the list of commands.";
        public const string HelpMessage = "LIST OF COMMANDS \r\n" +
            ".create- insert new item into the table\r\n" +
            ".update- update cell in the table\r\n" +
            ".read- print table\r\n" +
            ".delete- delete item from the table\r\n" +
            ".exit- stop program\r\n";
        public const string InfoStringForTable = "Choose which table you want to use (Authors, Genres or Books): ";
        public const string Successful = "Successful operation ";
    }
}
