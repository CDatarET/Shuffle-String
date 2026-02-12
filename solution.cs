public class Solution {
    public string RestoreString(string s, int[] indices) {
        char[] c = new char[s.Length];
        for(int i = 0; i < s.Length; i++){
            c[indices[i]] = s[i];
        }

        return(new string(c));
    }
}
