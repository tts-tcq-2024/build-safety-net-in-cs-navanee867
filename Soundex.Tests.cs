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
        Assert.Equal("W252", Soundex.GenerateSoundex("WashingtonDC"));
    }
        [Fact]
    public void HandlesStringWithVowels()
    {
        Assert.Equal("N623", Soundex.GenerateSoundex("NewYorkCity"));
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
        Assert.Equal("H213", Soundex.GenerateSoundex("HouseOfDragons"));
    }

    [Fact]
    public void HandlesStringWithConsecutiveSameCodes()
    {
        Assert.Equal("T520", Soundex.GenerateSoundex("Tymczak"));
    }

    [Fact]
    public void HandlesStringWithNoConsonants()
    {
        Assert.Equal("A000", Soundex.GenerateSoundex("AeioU"));
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
        Assert.Equal("S534", Soundex.GenerateSoundex("Santa De La Cruz"));
    }

    [Fact]
    public void HandlesHyphenatedString()
    {
        Assert.Equal("M235", Soundex.GenerateSoundex("Mc-Donalds"));
    }
}
