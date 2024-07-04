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
    public void HandlesSimpleString()
    {
        Assert.Equal("N153", Soundex.GenerateSoundex("Navaneeth"));
    }
    [Fact]
    public void HandlesStringWithDuplicates()
    {
        Assert.Equal("W252", Soundex.GenerateSoundex("Washington"));
    }
        [Fact]
    public void HandlesStringWithVowels()
    {
        Assert.Equal("R163", Soundex.GenerateSoundex("Robert"));
    }

    [Fact]
    public void HandlesStringWithSilentLetters()
    {
        Assert.Equal("P260", Soundex.GenerateSoundex("Pfiser"));
    }

    [Fact]
    public void HandlesUppercaseAndLowercase()
    {
        Assert.Equal(Soundex.GenerateSoundex("Lee"), Soundex.GenerateSoundex("LEE"));
    }

    [Fact]
    public void HandlesStringEndingInS()
    {
        Assert.Equal("S536", Soundex.GenerateSoundex("Sanders"));
    }

    [Fact]
    public void HandlesStringWithConsecutiveSameCodes()
    {
        Assert.Equal("T520", Soundex.GenerateSoundex("Tymczak"));
    }

    [Fact]
    public void HandlesStringWithNoConsonants()
    {
        Assert.Equal("A000", Soundex.GenerateSoundex("Aeo"));
    }

    [Fact]
    public void HandlesVeryLongString()
    {
        Assert.Equal("H653", Soundex.GenerateSoundex("Hernandez"));
    }

    [Fact]
    public void HandlesMixedCaseString()
    {
        Assert.Equal("A510", Soundex.GenerateSoundex("AmeBa"));
    }

    [Fact]
    public void HandlesStringWithSpaces()
    {
        Assert.Equal("D426", Soundex.GenerateSoundex("De La Cruz"));
    }

    [Fact]
    public void HandlesHyphenatedString()
    {
        Assert.Equal("M234", Soundex.GenerateSoundex("Mac-Dowell"));
    }
}
