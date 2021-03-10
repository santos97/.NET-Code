//import logo from './loginlogo.svg';
import React, { Component } from 'react'
import Login from './login.js'
import logo from './loginimg.jpg';
class App extends Component{
  // constructor(){
  //   super();
  //   this.state={
  //      email
  //   }
  // }
  render(){
    return(
      <>
       <Display />
      <Login/>
      </>
    )
  }
}

class Display extends Component{
  render()
  {
    return <img src={logo} alt="logo" class="img"/>
  }
}
export default App;
