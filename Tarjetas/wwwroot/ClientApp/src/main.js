const jsLogo = './public/javascript.svg'
const appLogo = './public/App.svg'
import { _ } from './helpers/dom.js'

import { setupCounter } from './counter.js' 

_('#app').innerHTML = `
  <div class="container mt-5">
    <div class="row">
      <div class="d-flex justify-content-around align-items-center py-5">
        <a href="#" target="_blank">
         <img src="${appLogo}" class="logo" alt="logo" width=128 />
        </a>
        <a href="#" target="_blank">
          <img src="${jsLogo}" class="logo vanilla" alt="JavaScript logo" width=128/>
        </a>
      </div>
    </div>
    <div class="card p-4 d-flex">
      <div class="card-title d-flex justify-content-center"> <h1>Hello from JavaScript!</h1> </div>
    <div class="card-body d-flex justify-content-center">
      <button id="counter" type="button" class="btn btn-small btn-primary"></button>
    </div>
    <p class="d-flex justify-content-center text-mutted">
      Click on the Count Button to counter
    </p>
    </div>
  </div>
`

setupCounter( _('#counter'))
