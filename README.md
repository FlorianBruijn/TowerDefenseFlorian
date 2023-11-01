	# TowerDefenseTemplate
Dit is een template wat door jullie te gebruiken is voor het juist inleveren van alle producten voor de Towerdefense beroepsopdracht. **Verwijder uiteindelijk de template teksten!**

Begin met een korte omschrijving van je towerdefense game en hoe deze werkt. Plaats ook een paar screenshots.

eerst teken je het pad voor de enemys

![drawing path](/readmeVisuals/screenshotDrawing.png)

dan koop je torens om op de enemys te schieten

![shooting enemys](/readmeVisuals/screenshotShooting.png)

als de enemys door komen ga je uiteindelijk dood

![dying](/readmeVisuals/screenshotDyine.png)


## Product 1: "DRY SRP Scripts op GitHub"

*"In dit script heb ik een array gebruikt voor al mijn waypoints die de speler zelf heeft getekend. Hierdoor heb ik mijzelf niet hoeven herhalen **(DRY)** in de code omdat ik met 1 regel het pad volgen via en for each loop.
[link naar script](/fire_defence/Assets/scripts/enemys/waypointFolower.cs)"*


*"dit script is dry want niks is he hard cod een de enige functie is on te schoeten.
[link naar script](/fire_defence/Assets/scripts/towers/shoot.cs)"*

## Product 2: "Projectmappen op GitHub"

Je commit de mappenstructuur van je unity project op github en verwijst vanuit je readme naar de root map van je project. Met een netjes en goed gestructureerde mappenstructuur en benamingen van files toon je aan dat je dit leerdoel beheerst. 

Dit is de [ROOT](/fire_defence/) folder van mijn unity project.

Zorg dat deze verwijst naar je Develop branch.

## Product 3: Build op Github

Je maakt in Unity een stabiele “build” van je game waarbij bugs en logs eerst zijn verwijderd. Deze buildfiles upload je in je repository onder releases.  Bij eventuele afwijkingen moeten deze worden gedocumenteerd in de release. (Bijv controller nodig of spelen via netwerk etc..) 

[mijn map met builds](/builds/fire_defence_0.1)

## Product 4: Game met Sprites(animations) en Textures 

![Textures Sprites](/readmeVisuals/20231031-2149-32.0428050.gif)

## Product 5: Issues met debug screenshots op GitHub 

Zodra je bugs tegenkomt maak je een issue aan op github. In de issue omschrijf je het probleem en je gaat proberen via breakpoints te achterhalen wat het probleem is. Je maakt screenshot(s) van het debuggen op het moment dat je via de debugger console ziet wat er mis is. Deze screenshots met daarbij uitleg over het probleem en de bijhorende oplossing post je in het bijhorende github issue. 
[Hier de link naar mijn issues]()

## Product 6: Game design met onderbouwing 

Je gebruikt een game design tool om je game design vast te leggen en te communiceren. Daarnaast onderbouw je de design keuzes ten aanzien van “playability” en “replayability” voor je game schriftelijk. 


Omschrijf per mechanic welke game design keuzes je hebt gemaakt en waarom je dit hebt gedaan.

*  **in mijn game kan je zelf het pad voor de enemys tekenen** 

*door het pad langer of korter of meer gebogen te maken wordt het moeilijker of makkelijker je kan alleen tussen 2 bases tekenen*

*  **de enemys kunnen over het pad lopen wat jij zelf hebt getekend**

*nadat je het pad hebt getekend lopen de enemys over jouw pad naar jouw base vanaf hun base*

*  **in mijn game kan je towers kopen**

*door op de koop knop te klikken gaat het aangegevven aantal geld van je geld af en als je niet genoeg geld hebt werkt het niet*

*  **in mijn game geven enemys geld**

*als enemys dood gaan krijg jij meer geld om towers te kopen*

*  **in mijn game krijg je meer geld per enemy als je pad korter is**

*als het pad wat de speler korter is krijg je meer geld voor balance*

*  **in mijn game kan je geen torens op onmogelijke plekken plaatsen**

*bijvoorbeeld in een andere toren of op het pad*

## Product 7: Class Diagram voor volledige codebase 

![](/readmeVisuals/Screenshot 2023-11-01 102219.png)

## Product 8: Prototype test video
Je hebt een werkend prototype gemaakt om een idee te testen. Omschrijf if je readme wat het idee van de mechanics is geweest wat je wilde testen en laat een korte video van de gameplay test zien. 

[![example test video](/readmeVisuals/langeVid.mp4)

## Product 9: SCRUM planning inschatting 

Je maakt een SCRUM planning en geeft daarbij een inschatting aan elke userstory d.m.v storypoints / zelf te bepalen eenheden. (bijv. Storypoints, Sizes of tijd) aan het begin van een nieuwe sprint update je deze inschatting per userstory. 

Plaats in de readme een link naar je trello en **zorg ervoor dat je deze openbaar maakt**

[Link naar de openbare trello](https://trello.com/b/39beMbag/td-game)

## Product 10: Gitflow conventions

Je hebt voor je eigen project in je readme gitflow conventies opgesteld en je hier ook aantoonbaar aan gehouden. 

De gitflow conventions gaan uit van een extra branch Develop naast de "Master"/"Main". Op de main worden alleen stabiele releases gezet.

Verder worden features op een daarvoor bedoelde feature banch ontwikkeld. Ook kun je gebruik maken van een hotfix brancg vanaf develop.

Leg hier uit welke branches jij gaat gebruiken en wat voor namen je hier aan gaat meegeven. Hoe vaak ga je comitten en wat voor commit messages wil je geven?

Meer info over het gebruiken van gitflow [hier](https://www.atlassian.com/git/tutorials/comparing-workflows/gitflow-workflow)

