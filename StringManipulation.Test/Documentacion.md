#Documentacion pruebas unitarias XUnit

#introducción: 
En este documento se describen los casos de prueba realizados para cada método de la clase `StringOperations` del proyecto `StringManipulation`.

##Descripcion: 
El proyecto `StringManipulation`contiene una clase llamada `StringOperations`, que proporciona metodos para manipular cadenas de texto.

##Objetivos:
Objetivos de los Casos de Prueba:

1. Probar Funcionalidades Individuales: Cada caso de prueba se centra en probar una funcionalidad específica del software, asegurando que funcione como se espera.
2. Cubrir Diferentes Escenarios: Los casos de prueba deben cubrir una variedad de escenarios, incluyendo casos de uso normales, casos límite y casos de error.
3. Documentar el Comportamiento Esperado: Los casos de prueba actúan como una documentación viva del comportamiento esperado del software en diferentes situaciones.

### 1. Metodo ConcatenaStrings
- **Proposito:** Concatenar dos cadenas de texto
- **Pasos**
      1. Llamar al metodo ConcatenateStrings con dos cadenas de texto.
    --**Resultado Esperado:** La concatenación de las dos cadenas de texto, separadas por un espacio.
    -- **Caso de Prueba:**

  ```csharp
  [test]
  public void TestConcatenarString()
  {
      // Arrange
      var stringConcatenar = new StringOperations();

      // Act
      var resultado = stringConcatenar.ConcatenateStrings("Bienvenido", "Usuario");

      // Assert
      Assert.Equal("Bienvenido Usuario", resultado);
  }

### 2. Metodo ReverseString
- **Proposito:** Revertir una cadena de texto
- **Pasos**
      1. Llamar al metodo ReverseString con dos cadenas de texto.
    --**Resultado Esperado:** La cadena de texto invertida
    --**Caso de prueba**

     ```csharp
     [test]
  public void TestReverseString()
  {
      // Arrange
      var stringReverse = new StringOperations();

      // Act
      var resultado = stringReverse.ReverseString("Manuela");

      // Assert
      Assert.Equal("aleunaM", resultado);
  }

### 3. Metodo GetStringLenght 
- **Proposito:** Obtener la longitud de una cadena de texto
- **Pasos** 
      1. Llamar al metodo GetStringLenght con una cadena de texto
    --**Resultado obtenido:** La longitud de la cadena de texto
    --**Caso de prueba:**

     ```csharp

    [test]
    public void TestGetStringLength()
    {
        //arrange
        var stringLength = new StringOperations();

        //act
        var resultado = stringLength.GetStringLength("Manuela");

        //asssert
        Assert.Equal(7,resultado);
    }

### 4. Metodo RemoveWhitespace
-  **Proposito:** Eliminar los espacios en blanco de una cadena de texto
-  **Pasos:**
     1. Llamar al método RemoveWhitespace con una cadena de texto que contenga espacios en blanco.
     --**Resultado obtenido:** La cadena de texto sin espacios en blanco.
     --**Caso de prueba:**

     ```csharp

    [test]
    public void TestRemoveWhitespace()
    {
        //arrange
        var stringRemoveSpace = new StringOperations();

        //act
        var resultado = stringRemoveSpace.RemoveWhitespace(" Manuela Sebastian ");

        //asssert
        Assert.Equal("ManuelaSebastian",resultado);
    }

### 5. Metodo TruncateString
-  **Proposito:** Truncar una cadena de texto a una longitud especifica.
-  **Pasos:**
     1. Llamar al método TruncateString con una cadena de texto y una longitud maxima.
     --**Resultado obtenido:** La cadena de texto truncada a la longitud especificada.
     --**Caso de prueba:**

    ```csharp
  [test]
  public void TestTruncateString()
  {
      // Arrange
      var stringTruncate = new StringOperations();

      // Act
      var resultado = stringTruncate.TruncateString(" Manuela Sebastian ", 4);

      // Assert
      Assert.Equal("Manu", resultado);
  }

### 6. Metodo IsPalindrome
-  **Proposito:** Determinar si una cadena de texto es un Palindromo 
-   **Pasos:**
     1. Llamar al metodo IsPalindrome con una cadena de texto
     -- **Resultado obtenido:** Verdadero si la cadena de texto es un palindromo, falso en caso contrario
     -- **1. Caso de prueba:** (Verdadero)
     -- **2. Caso de prueba:** (Falso)

     ```csharp
     [test]
    public void TestIsPalindrome_True()
    {
        // Arrange
        var stringPalindromo = new StringOperations();

        // Act
        var resultado = stringPalindromo.IsPalindrome("somos o no somos");

        // Assert
        Assert.True(resultado);
    }


     [test]
     public void TestIsPalindrome_False()
    {
        // Arrange
        var stringPalindromo = new StringOperations();

        // Act
        var resultado = stringPalindromo.IsPalindrome("hello world");

        // Assert
        Assert.False(resultado);
    }

### 6. Metodo CountOccurrence
-  **Proposito:** Contar las ocurrencias de un caracter en una cadena de texto  
-   **Pasos:**
     1. Llamar al metodo CountOccurrence con una cadena de texto y un caracter
     -- **Resultado obtenido:** El numero de ocurrencias del caracter en la cadena de texto
     -- **Caso de prueba:** 

     ```csharp
    [test]
    public void TestCountOcurrences()
    {
        // Arrange
            var stringCountOcurrences = new StringOperations();

            // Act
            var resultado = stringCountOcurrences.CountOccurrences("hello", 'l');

            // Assert
            Assert.Equal(2, resultado);
    }

### 7. Metodo Pluralize
- **Proposito:** Convertir una palabra en su forma plural.
- **Pasos:**
     1. Llamar al metodo Pluralize con una palabra 
     -- **Resultado obtenido:** La palabra en su forma plural 
     -- **Caso de prueba:**

     ```csharp
     [test]
    public void TestPluralize()
    {
        // Arrange
    var stringPluralize = new StringOperations();

    // Act
    var resultado = stringPluralize.Pluralize("manzana");

    // Assert
    Assert.Contains("manzanas", resultado);
    }

### 8. Metodo QuantintyInWords
-  **Proposito:** Convertir un cantidad en palabra 
-  **Pasos:** 
     1. Llamar al método QuantintyInWords con una palabra y una cantidad.
     -- **Resultado obtenido:** La cantidad en palabras
     -- **Caso de prueba:**

     ```csharp
     [test]
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

### 9. Metodo FromRomanToNumber
-  **Proposito:** Convertir un numero romano en un numero decimal.
-  **Pasos:** 
      1. Llamar al metodo FromRomanToNumber Con un numero romano.
    -- **Resultado obtenido:**El numero decimal correspondiente al numero romano.
    -- **Caso de prueba:** 

     ```csharp
     [test]
    public void TestFromRomanToNumber()
    {
       // Arrange
       var stringRomanNumber = new StringOperations();

       // Act
       var result = stringRomanNumber.FromRomanToNumber("XIII");

       // Assert
       Assert.Equal(13, result);
    }

### 10. Metodo ReadFile
-  **Proposito:** Leer un archivo utilizando un conector de lectura de archivos.
-  **Pasos:**
     1. Crear un mock del conector de lectura de archivos.
     2. Llamar al método ReadFile con el mock del conector y el nombre del archivo.
    -- **Resultado obtenido:** El contenido del archivo leido.
    -- **Casos de prueba:**

     ```csharp
     [test]
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

#Conclusiones:
Estos tipos de asertos son fundamentales para escribir casos de prueba efectivos que validen el comportamiento y la funcionalidad de un sistema de software de manera exhaustiva.

1. Assert.NotNull:
    - Propósito: Verifica que un objeto no sea nulo.
    - Uso: Se utiliza para asegurar que un valor devuelto no sea nulo, lo que garantiza que el resultado de una operación no esté ausente.

2. Assert.Equal:
    - Propósito: Compara dos valores para asegurarse de que sean iguales.
    - Uso: Se utiliza para verificar que el resultado de una operación sea exactamente igual al valor esperado

3. Assert.Contains:
    - Propósito: Verifica que una cadena o colección contenga un valor específico.
    - Uso: Se utiliza para comprobar si una cadena contiene cierto texto o si una colección incluye un elemento particular.

4. Assert.False:
    - Propósito: Verifica que una condición sea falsa.
    - Uso: Se utiliza para asegurarse de que una afirmación negativa sea verdadera, como la ausencia de un resultado o el fallo de una condición.

5. Assert.True:
    - Propósito: Verifica que una condición sea verdadera.
    - Uso: Se utiliza para asegurarse de que una afirmación positiva sea verdadera, como la presencia de un resultado o la verificación de una condición.



   
