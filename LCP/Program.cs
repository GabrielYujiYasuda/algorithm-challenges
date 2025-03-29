using LCP;

var lcp = new LongestCommon();
var input = new string[] { "flower", "flow", "flight" };

var result = lcp.Execute(input);

Console.WriteLine(result);
