namespace Microsoft50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 出力するデータを配列に格納する
            Lazy<string[]> data = new Lazy<string[]>(() =>
            {
                return new string[]
                {
                    "➖✨➖➖➖➖➖➖✨➖➖",
                    "✨🟥🟥🟥🟥➖🟩🟩🟩🟩➖",
                    "➖🟥➖➖➖➖🟩➖➖🟩➖",
                    "➖🟦🟦🟦🟦➖🟨➖➖🟨➖",
                    "➖➖➖➖🟦➖🟨➖➖🟨➖",
                    "➖🟦🟦🟦🟦➖🟨🟨🟨🟨✨",
                    "➖✨➖➖➖➖➖➖➖✨➖"
                };
            });
            // chcp(65001) to set the console to UTF-8
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // dataの内容をLINQを使って、コンソールに出力する
            data.Value.ToList().ForEach(line =>
            {
                for (int i = 0; i < line.Length; i++)
                {
                    string symbol = line.Substring(i, 1);
                    Console.ForegroundColor = symbol switch
                    {
                        "\u2728" => ConsoleColor.DarkYellow, // ✨
                        "\uDFE5" => ConsoleColor.Red,    // 🟥
                        "\uDFE9" => ConsoleColor.Green,  // 🟩
                        "\uDFE6" => ConsoleColor.Blue,   // 🟦
                        "\uDFE8" => ConsoleColor.Yellow, // 🟨
                        _ => ConsoleColor.White
                    };
                    Console.Write(symbol);
                }
                Console.WriteLine();
            });

            // 色をリセットする
            Console.ResetColor();
        }
    }
}
