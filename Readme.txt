Vorteile und Nutzung des Interactive WebAssembly Render Mode:
- der Server auf dem die Webseite gehostet wird, wird weniger belastet, da die Render-Logik auf dem Client laeuft
- es muessen weniger Daten zwischen Webseite und Browser uebertragen werden
- das kann auch die Ladezeiten der Webseite verkuerzen
- wenn die Verbindung zum Server unterbrochen wird, kann der WebAssembly Render Mode weiterhin funktionieren bzw. man verliert nicht den aktuellen Zustand der Anwendung
(z.B. beim Fahren durch einen Tunnel)

Warum z.B. localStorage nur hier nutzbar ist:
- der localStorage wird auf der Client-Seite gespeichert, da der WebAssembly Render Mode auf der Client-Seite laeuft, kann er diesen nutzen
- allerdings kann man ihn auch im Server-Render Mode den localStorage nutzen, muss dazu allerdings JSInteropt verwenden, was etwas aufwaendiger ist und den Code etwas komplizierter gestaltet



Moegliche Erweiterungen:
- MudBlazor Componenten in eigener Componenten Bibliothek wrappen z.B. MudText => OwText
- Extensions Methoden fuer Services hinzufuegen, um die Services einfacher nutzbar zu machen => weniger Boilerplate Code je Service
- mehr Content Anzeigen
- error logging hinzufuegen
- Lokalisierung hinzufuegen