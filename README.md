# PR1_SaveOcean

- [Main del programa](/PR1_SaveOcean/Program.cs)
- [Classes amb Objectes](/ClassObject)
- [Classes amb Funcions i Procediments](/ClassMethods)
- [Unit Tests](/TestProject)
- [UML](/UML)

## UML 
### Draw.io
![texto_alternativo](/UML/ClassDiagram_Drawio.png)

### Visual Studio
![texto_alternativo](/UML/ClassDiagram_VStudio.png)

## INFORMACIO EXTRA
### REFACTORITZACIÓ
- En el IDE del VisualStudio a l'apart dels "AVISOS" com els "Errors" i dels "Warnings" hi habia un apartat de "Message", que mostraba algunes recomenacions de simplificacions pel codi, he volgut aplicarles, per deixar sense cap "AVIS". Un dels exemples d'aquestes simplificacions seria la del constructor primari, mostrarla directament amb la classe.
- Sobre els "Warnings" només tenir en compte els valors d'strings que poden ser "NULLS".
### UNIT TESTING
- Hi ha una funcio que no he fet el test, ja que he implementat la funció per estalviar linies de codi. És la de "Utility.ValidateInput(errorMessage, min, max);", dintre de la funcio hi ha un "Console.ReadLine();"
### INTELLISENSE (COMENTARI)
- En els casos de les les herencies, només he aplicat els comentaris en la superclasse (Pare).


