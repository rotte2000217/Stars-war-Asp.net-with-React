import React from 'react';
export default class Simple_Question extends React.Component {
  constructor(props) {
    super(props)
    }

render() {
    return (<div className="App-Theme">
    <h3>{this.props.Question}</h3>
    <h3>{this.props.Ans}</h3>
    </div>)
    }
  }