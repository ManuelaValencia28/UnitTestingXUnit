namespace StringManipulationTest.cs;

public class UnitTest1
{
    [Fact]
    public void TestConcatenarString()
    {
        //arrange
         var stringConcatenar = new StringOperations();

        //act
        var resultado = stringOperations.ConcatenateStrings("Bienvenido", " Usuario");

        //asssert
        Assert.Equal("bienvenido Usuario", resultado);

    }

    [Fact]
    public void TestReverseString()
    {
        //arrange
        var stringReverse = new StringOperations();

        //act
        var resultado = stringReverse.ReverseString("Manuela");

        //asssert
        Assert.Equal("aleunaM",resultado)
    }

    [Fact]
    public void TestGetStringLength()
    {
        //arrange
        var stringLength = new StringOperations();

        //act
        var resultado = stringLength.GetStringLength("Manuela");

        //asssert
        Assert.Equal(7,resultado);
    }

    [Fact]
    public void TestRemoveWhitespace()
    {
        //arrange
        var stringRemoveSpace = new StringOperations();

        //act
        var resultado = stringRemoveSpace.RemoveWhitespace(" Manuela Sebastian ");

        //asssert
        Assert.Equal("ManuelaSebastian",resultado);
    }

    [Fact]
    public void TestTruncateString()
    {
        //arrange
        var stringTruncate = new StringOperations();

        //act
        var resultado = stringTruncate.TruncateString(" Manuela Sebastian ",4);

        //asssert
        Assert.Equal("Manu",resultado);
    }

    [Fact]
    public void TestIsPalindrome_True()
    {
        //arrange
        var stringPalindromo = new StringOperations();

        //act
        var resultado = stringPalindromo.IsPalindrome("somos o no somos");

        //asssert
        Assert.True(resultado);
    }

    [Fact]
    public void TestIsPalindrome_False()
    {
        // Arrange
        var stringPalindromo = new StringOperations();

        // Act
        var resultado = stringOperations.IsPalindrome("hello world");

        // Assert
        Assert.False(resultado);
    }

    [Fact]
    public void TestCountOcurrences()
    {
        // Arrange
            var stringCountOcurrences = new StringOperations();

            // Act
            var resultado = stringCountOcurrences.CountOccurrences("hello", 'l');

            // Assert
            Assert.Equal(2, resultado);
    }

    [Fact]
    public void TestPluralize()
    {
        // Arrange
    var stringPluralize = new StringOperations();

    // Act
    var resultado = stringPluralize.Pluralize("manzana");

    // Assert
    Assert.Contains("manzanas", resultado);
    }

    [Fact]
    public void TestQuantintyInWords()
    {
        // Arrange
        var stringQuantinty = new StringOperations();

        // Act
        var resultado = stringQuantinty.QuantintyInWords("persona", 3);

        // Assert
        Assert.Contains("tres", resultado);
        Assert.Contains("personas", resultado); 
    }
    [Fact]
    public void TestFromRomanToNumber()
    {
        // Arrange
        var stringRomanNumber = new StringOperations();

        // Act
        var result = stringRomanNumber.FromRomanToNumber("XIII");

        // Assert
        Assert.True(result == 13);
    }
    [Fact]
    public void TestReadFile()
    {
        // Arrange
        var mockFileReader = new Mock<IFileReaderConector>();
        mockFileReader.Setup(fr => fr.ReadString(It.IsAny<string>())).Returns("Hello World");
        
        var stringReadFile = new StringOperations(mockFileReader.Object);

        // Act
        var resultado = stringReadFile.ReadFile(mockFileReader.Object, "test.txt");

        // Assert
        Assert.NotNull(resultado);
    }
}