using System;
using System.Collections.Generic;
using System.Text;

public class Soundex
{
    private static readonly Dictionary<char, char> soundexMapping = new Dictionary<char, char>
    {
        { 'B', '1' }, { 'F', '1' }, { 'P', '1' }, { 'V', '1' },
        { 'C', '2' }, { 'G', '2' }, { 'J', '2' }, { 'K', '2' }, { 'Q', '2' }, { 'S', '2' }, { 'X', '2' }, { 'Z', '2' },
        { 'D', '3' }, { 'T', '3' },
        { 'L', '4' },
        { 'M', '5' }, { 'N', '5' },
        { 'R', '6' }
    };

    public static string GenerateSoundex(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return string.Empty;
        }

        StringBuilder soundex = BuildSoundex(name);
        AppendWithZeroes(soundex);

        return soundex.ToString();
    }

    private static StringBuilder BuildSoundex(string name)
    {
        StringBuilder soundex = new StringBuilder();
        char firstLetter = char.ToUpper(name[0]);
        soundex.Append(firstLetter);
        char prevCode = GetSoundexCode(firstLetter);

        for (int i = 1; i < name.Length && soundex.Length < 4; i++)
        {
            AppendNextSoundexCode(soundex, name[i], ref prevCode);
        }

        return soundex;
    }

    private static void AppendNextSoundexCode(StringBuilder soundex, char letter, ref char prevCode)
    {
        char code = GetSoundexCode(letter);
        if (ShouldAppendCode(code, prevCode))
        {
            soundex.Append(code);
            prevCode = code;
        }
    }

    private static bool ShouldAppendCode(char code, char prevCode)
    {
        return code != '0' && code != prevCode;
    }

    private static void AppendWithZeroes(StringBuilder soundex)
    {
        while (soundex.Length < 4)
        {
            soundex.Append('0');
        }
    }

    private static char GetSoundexCode(char c)
    {
        c = char.ToUpper(c);
        return soundexMapping.TryGetValue(c, out char code) ? code : '0';
    }
}
