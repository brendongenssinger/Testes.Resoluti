import React from 'react';
import logo from './logo.svg';
import './App.css';

function App() {
  return (
    <div className="container bordered-container">
      <div className="container text-center">
      <div className="row">
        <div className="col">
          <h2>Cadastrar Usuário</h2>
          <div className="row">
          <div className="mb-3">
            <label className="form-label">Username</label>
            <input type="email" className="form-control" id="exampleFormControlInput1" placeholder="name@example.com"/>
            <label className="form-label">Username</label>
            <input type="email" className="form-control" id="exampleFormControlInput1" placeholder="name@example.com"/>
          </div>  
          </div>
        
          <div className="mb-3">
            
          </div>

        <div className="mb-3">
          <label className="form-label">Example textarea</label>
          <textarea className="form-control" id="exampleFormControlTextarea1" ></textarea>
        </div>
        </div>
        <div className="col bordered-imagem">
          Text
        </div>     
      </div>
    </div>
  </div>
  );
}

export default App;
