import React,{useState} from 'react'

const Mybutton = ()=>{
    const [count, setState] =useState(0);
    const handleit=(event)=>{
        setState(count+1);
    }
    return <><h1>{count}</h1>
    <button onClick={handleit}>click here</button></>
}

// const Mybutton =props =><button>click here</button>

export default Mybutton