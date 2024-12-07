# Firewall Blocker
Licensed under **Apache License 2.0**\
**Some antivirus programs may flag it as a potential threat, but this is a false positive.**

### Supported languages
<p float="left">
  <img src="https://raw.githubusercontent.com/hampusborgos/country-flags/refs/heads/main/png100px/br.png" width="30" alt="Português"/>
  <img src="https://raw.githubusercontent.com/hampusborgos/country-flags/refs/heads/main/png100px/ru.png" width="30" alt="Русский" /> 
  <img src="https://raw.githubusercontent.com/hampusborgos/country-flags/refs/heads/main/png100px/us.png" width="40" alt="English" />
</p>


## How to build
### Prerequisites

| Tools |
| ------------ |
| [Visual Studio 2022](https://visualstudio.microsoft.com) |

### Installing and Testing
- Clone this repository
- Open the solution on your Visual Studio 2022 **or above**
- Select debug and click on run

## Contributing
### Add new features
Fell free to fork the repo and open a pull request

### Add new languages
- Create a Form with translations on root folder of the project
- Go to **Properties** and create strings.**langcode**.resx (Change langcode for the specific lang code you are working on)
- Go to **FirewallBlocker.csproj** and embed your new language with the line ``<EmbeddedResource Include="Properties\strings.**langcode**.resx" />``

## Example of version 2.0
![2.0 working](https://i.imgur.com/ZZY7YEp.gif)
