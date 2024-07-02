using System;
using System.Text;

public class Soundex
{
    public static string GenerateSoundex(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return string.Empty;
        }

        StringBuilder soundex = new StringBuilder();
        soundex.Append(char.ToUpper(name[0]));
        char prevCode = GetSoundexCode(name[0]);

        for (int i = 1; i < name.Length && soundex.Length < 4; i++)
        {
            char code = GetSoundexCode(name[i]);
            if (code != '0' && code != prevCode)
            {
                soundex.Append(code);
                prevCode = code;
            }
        }

        while (soundex.Length < 4)
        {
            soundex.Append('0');
        }

        return soundex.ToString();
    }

    private static char GetSoundexCode(char c)
    {
        c = char.ToUpper(c);
        return soundexMapping.TryGetValue(c, out char code) ? code : '0';
    }

    private static readonly Dictionary<char, char> soundexMapping = new Dictionary<char, char>
    {
        { 'B', '1' }, { 'F', '1' }, { 'P', '1' }, { 'V', '1' }, { 'C', '2' }, { 'G', '2' }, { 'J', '2' },
        { 'K', '2' }, { 'Q', '2' }, { 'S', '2' }, { 'X', '2' }, { 'Z', '2' }, { 'D', '3' }, { 'T', '3' },
        { 'L', '4' }, { 'M', '5' }, { 'N', '5' }, { 'R', '6' }
    };
}
