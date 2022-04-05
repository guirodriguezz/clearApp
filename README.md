
<h1 align="center"><strong>💻Clear App - Documentação</strong></h1>

---

## O que foi utilizado para realização do desafio e o por que:
- <strong>Refit</strong> - Para auxiliar no fluxo de consumo da api.
- <strong>Acr.UserDialogs</strong> - Para usar mais opções do que o ActvityIndicator.
- <strong>Xam.Connnectivity</strong> - Para não apenas verificar a conexão de hardware do smartphone, mas também realizar o ping de rede.

## Custom Controls:
- <strong>BasePage</strong> - Criado para facilitar a construção de telas que continham o mesmo padrão, no caso tela de Listagem de Ordens e tela de Detalhes da Ordem.
- <strong>EntryClearOrder</strong> - Criado também um componente de Entry para adicionar e subtrair a quantidade de ordens para venda.

## Custom Renderers:
- <strong>CustomEntryRenderer</strong> - Foi recriado o entry original para não conter linhas, para assim ser construido seu custom control de um entry com underline.

## Font Icons:
 Na medida do possível utilizei font icons ao invés de imagens, para ajudar no tamanho e desempenho do aplicativo. Salvei todas as imagens em SVG e depois utilizei um programa pra converter-las em arquivo .ttf único e adicionar no projeto via embedded resource.
 
## Extra:
- <strong>OrdersDetails e OrdersSaleFinished</strong> - Adicionei uma tela de Detalhes das Ordens e uma tela de confirmação. Essas duas telas foram adicionadas para simular um fluxo mais ou menos completo de venda de ativos.
- <strong>Acessibilidade por voz</strong> - Adicionei também Acessibilidade por voz, pois acho importante ter esse tipo de preocupação em qualquer aplicativo, além de ser de simples implementação. 
- <strong>SecureStorage</strong> - Utilizei o SecureStorage do Essentials para salvar a lista de ordens e ao verificar a conectividade do usuário, utilizar essas ordens salvas em modo offline, afim de que o usuário consiga continuar o fluxo de venda. No modo online é sempre buscado os dados mais recentes.
 
 ## O que não fiz e o por que:
 - <strong>Testes de unidade e interface</strong> - Mesmo já tendo algum conhecimento a respeito de testes de unidade com xUnit no padrão AAA, é algo que eu ainda estou estudando melhor a respeito, assim como os Testes de interface. Então não quis arriscar fazer algo mal feito apenas por fazer.
 
## Resultado - Android

<table>
  <tr>
    <td align="center">
      <a href="#">
        <img src="https://github.com/guirodriguezz/clearApp/blob/main/Images/Android/android1.png" width="300px;"/><br>
        <sub>
          <b>Login Android</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="#">
        <img src="https://github.com/guirodriguezz/clearApp/blob/main/Images/Android/android2.png" width="300px;"/><br>
        <sub>
          <b>Browser Android</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="#">
        <img src="https://github.com/guirodriguezz/clearApp/blob/main/Images/Android/android3.png" width="300px;"/><br>
        <sub>
          <b>Orders lista Android</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="#">
        <img src="https://github.com/guirodriguezz/clearApp/blob/main/Images/Android/android4.png" width="300px;"/><br>
        <sub>
          <b>Lista Detalhes Android</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="#">
        <img src="https://github.com/guirodriguezz/clearApp/blob/main/Images/Android/android5.png" width="300px;"/><br>
        <sub>
          <b>Confirmação Venda Android</b>
        </sub>
      </a>
    </td>
  </tr>
</table>

## Resultado - iOS

<table>
  <tr>
    <td align="center">
      <a href="#">
        <img src="https://github.com/guirodriguezz/clearApp/blob/main/Images/iOS/ios1.png" width="300px;"/><br>
        <sub>
          <b>Login iOS</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="#">
        <img src="https://github.com/guirodriguezz/clearApp/blob/main/Images/iOS/ios2.png" width="300px;"/><br>
        <sub>
          <b>Lista Ordens iOS</b>
        </sub>
      </a>
    </td>
    <td align="center">
      <a href="#">
        <img src="https://github.com/guirodriguezz/clearApp/blob/main/Images/iOS/ios3.png" width="300px;"/><br>
        <sub>
          <b>Lista Detalhes iOS</b>
        </sub>
      </a>
    </td>
  </tr>
</table>


No mais agradeço muito a oportunidade :)
