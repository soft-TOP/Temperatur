# Zusammenspiel verschiedener Techniken:
#### Klassen
#### Zugriffsmodifizierer
#### Überladung
#### Unit-Test
#### Attribute
#### Reflection
#### Compiler-direktiven

***Dient nur zu Schulungszwecken***

Erstellt eine Klasse Temperatur. In dieser erfolgt die Umwandlung in die verschiedeneren Einheiten. Es gibt eine Exception für den absoluten Nullpunkt. Außerdem verfügt diese Klasse über verschiedene Arten der Addition und Subtraktion von Temperaturdifferenzen. _Zu einer Temperatur kann man immer nur eine **Temperaturdifferenz** addieren oder davon subtrahieren, nie eine echte Temperatur!_<p>
Die Standardoperatoren "+" und "-" werden überladen, so dass man - im Gegensatz zur physikalischen Realität - eine Temperatur zur anderen addieren kann.
Mittels Attribute und Reflection werden einige der Methoden im Hauptprogramm angezeigt und ausgeführt.
Um die Korrektheit der Rechenwege zu überprüfen wurde eine Test-Unit erstellt und eingebunden, allerdings nur zum kleinen Teil wirklich benutzt.<p>
***
Attributparameter sind ausschließlich Konstantenwerte der folgenden Typen:
  + Einfache Typen (bool, byte, char, short, int, long, float und double)
  + string
  + System.Type
  + enums
  + object (Das Argument für einen Attributparameter vom Typ object muss ein konstanter Wert sein, der einem der oben   genannten Typen entspricht.)
  + Eindimensionale Arrays eines der oben genannten Typen<p>
  
***

Weitergehende Informationen gibt es hier:
  - Gute Erklärung zu Attributen allgemein
  http://www.guidetocsharp.de/Attributes.aspx
  - Microsofts "Lernprogramm für Attribute"
  https://msdn.microsoft.com/de-de/library/aa288454(v=vs.71).aspx
  - Alle von Microsoft vordefinierten Attribute
  https://msdn.microsoft.com/de-de/library/system.attribute(v=vs.110).aspx

***
--> _Keine Fehlerbehandlung!!_
