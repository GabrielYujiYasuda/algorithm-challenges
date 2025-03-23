using LCP;

var lcp = new LongestCommon();
var input = new string[] { "dog", "racecar", "car" };

var result = lcp.Execute(input);

Console.WriteLine(result);
