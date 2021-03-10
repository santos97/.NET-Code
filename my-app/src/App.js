//import logo from './logo.svg';
//import './App.css';
import { Component } from "react";
import React from 'react'
import Mybutton from './button.js'

class App extends Component{
  // constructor(){
  //   super();
  //   this.state={
  //     count:0
  //   }
  // }
  render(){
    return(
      <>
      {/* <h1>{this.state.count}</h1> */}
      {/* <Mybutton
      //count = {this.state.count}
      onClick={(prop)}/> */}

      
      {/* <Display count={this.state.count}/> */}

      {/* below uses useState in fun comp */}
      <Mybutton />


      {/* below uses setState */}
      {/* <button onClick={()=>this.setState({
        count:this.state.count+1
      })}>Click here</button> */}
      </>
    )
  }
}

class Display extends Component{
  render()
  {
    return <h1>{this.props.count}</h1>
  }
}

export default App;




















// function App() {
//   return (
//     <div className="App">
//       <header className="App-header">
//         <img src={logo} className="App-logo" alt="logo" />
//         <p>
//           Edit <code>src/App.js</code> and save to reload.
//         </p>
//         <a
//           className="App-link"
//           href="https://reactjs.org"
//           target="_blank"
//           rel="noopener noreferrer"
//         >
//           Learn React
//         </a>
//       </header>
//     </div>
//   );
// }