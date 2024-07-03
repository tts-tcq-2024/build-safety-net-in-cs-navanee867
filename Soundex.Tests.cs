using Xunit;

public class SoundexTests
{
    [Fact]
    public void HandlesEmptyString()
    {
        Assert.Equal(string.Empty, Soundex.GenerateSoundex(""));
    }

    [Fact]
    public void HandlesSingleCharacter()
    {
        Assert.Equal("A000", Soundex.GenerateSoundex("A"));
    }
    [Fact]
    public void HandlesSimpleName()
    {
        Assert.Equal("N153", Soundex.GenerateSoundex("Navaneeth"));
    }
    [Fact]
    public void HandlesNameWithDuplicates()
    {
        Assert.Equal("W252", Soundex.GenerateSoundex("Washington"));
    }
        [Fact]
    public void HandlesNameWithVowels()
    {
        Assert.Equal("R163", Soundex.GenerateSoundex("Robert"));
    }

    [Fact]
    public void HandlesNameWithSilentLetters()
    {
        Assert.Equal("P260", Soundex.GenerateSoundex("Pfiser"));
    }

    [Fact]
    public void HandlesUppercaseAndLowercase()
    {
        Assert.Equal(Soundex.GenerateSoundex("Lee"), Soundex.GenerateSoundex("LEE"));
    }

    [Fact]
    public void HandlesNameEndingInS()
    {
        Assert.Equal("S536", Soundex.GenerateSoundex("Sanders"));
    }

    [Fact]
    public void HandlesNameWithConsecutiveSameCodes()
    {
        Assert.Equal("T520", Soundex.GenerateSoundex("Tymczak"));
    }

    [Fact]
    public void HandlesNameWithNoConsonants()
    {
        Assert.Equal("A000", Soundex.GenerateSoundex("Aeo"));
    }

    [Fact]
    public void HandlesVeryLongName()
    {
        Assert.Equal("H653", Soundex.GenerateSoundex("Hernandez"));
    }

    [Fact]
    public void HandlesMixedCaseName()
    {
        Assert.Equal("A510", Soundex.GenerateSoundex("Ameba"));
    }

    [Fact]
    public void HandlesNameWithSpaces()
    {
        Assert.Equal("D426", Soundex.GenerateSoundex("De La Cruz"));
    }

    [Fact]
    public void HandlesHyphenatedName()
    {
        Assert.Equal("M234", Soundex.GenerateSoundex("Mac-Dowell"));
    }
}
