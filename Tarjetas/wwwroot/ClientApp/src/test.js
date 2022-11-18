const jslogo = './public/JavaScriptLogo.svg'
import { setupCounter } from './counter.js' 

document.querySelector('#app').innerHTML = `
  <div>
    <a href="#" target="_blank">
      <img src="./public/App.svg" class="logo" alt="logo" />
    </a>
    <a href="#" target="_blank">
      <img src="${jslogo}" class="logo vanilla" alt="JavaScript logo" />
    </a>
    <h1>Hello from JavaScript!</h1>
    <div class="card">
      <button id="counter" type="button" class="btn btn-small btn-primary"></button>
    </div>
    <p class="read-the-docs">
      Click on the Count Button to counter
    </p>
  </div>
`

setupCounter(document.querySelector('#counter'))
