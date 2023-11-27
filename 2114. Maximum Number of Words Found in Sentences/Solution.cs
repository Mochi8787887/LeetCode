public class Solution {
   public int MostWordsFound(string[] sentences) {
       int maxWords = 0;
       // 遍歷每個句子
       foreach (var sentence in sentences) {
           // 使用空格分割句子成單詞陣列
           string[] words = sentence.Split(' ');
           // 如果目前句子的單詞數大於目前的最大單詞數，則更新最大值
           if (words.Length > maxWords) {
               maxWords = words.Length;
           }
       }
       return maxWords;
   }
}
