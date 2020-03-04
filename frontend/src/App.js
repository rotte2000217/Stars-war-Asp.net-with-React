import React, {Component} from 'react';
import logo from './Star_Wars_Logo.svg.png';
import Simple_Question from './simplequestion'
import List_Question_3 from './question3'
import List_Question_4 from './question4'

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      Q1_Question: "Which of all Star Wars movies has the longest opening crawl ?",
      Q1_Ans: "",
      Q2_Question: "What character (person) appeared in most of the Star Wars films? ",
      Q2_Ans: ""
    };
  }
  render()
  {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <h1 className="App-title">Welcome to the prototype interactive test</h1>
        </header>
        <div className="App-Theme">
        <h2>{this.state.Q1_Question}</h2>
        <h3>{this.state.Q1_Ans}</h3>
        <h2>{this.state.Q2_Question}</h2>
        <h3>{this.state.Q2_Ans}</h3>
        <List_Question_3 />
        <List_Question_4 />
        </div>
      </div>
    );
  };
  componentWillMount() {
    document.title = 'Dashboard';
    fetch("/api/OpeningCrawl", {
      method: 'GET'
  })
  .then(res => res.json())
  .then((dat) => {
  var data = JSON.parse(dat);
  if(data != null && data.length > 0 )
  {
    this.setState({Q1_Ans: data[0].title});
  }
 })

 fetch("/api/CharacterAppearance", {
  method: 'GET'
  })
  .then(res => res.json())
  .then((dat) => {
  var data = JSON.parse(dat);
  if(data != null && data.length > 0 )
  {
    this.setState({Q2_Ans: data[0].name});
  }
 })
}
}
export default App;