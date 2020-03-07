import React, {Component} from 'react';
import logo from './Star_Wars_Logo.svg.png';
import Question3 from './question3';
import Question4 from './question4';
import { styled } from '@material-ui/styles';
import Button from '@material-ui/core/Button';

const MyButton = styled(Button)({
  background: '#FFFF66',
  border: 0,
  borderRadius: 5,
  boxShadow: '0 3px 5px 2px rgb(238,232,170)',
  color: '#D2691E',
  height: 100,
  padding: '0 30px',
  fontSize:'25px',
  fontWeight:'bold'
});

class App extends Component {
  constructor(props) {
    super(props);
    this.state = {
      Q1_Question: "Which of all Star Wars movies has the longest opening crawl?",
      Q1_Ans: "",
      Q2_Question: "What character (person) appeared in most of the Star Wars films?",
      Q2_Ans: "",
      shouldHide: true
    };
  }
  render()
  {
    return (
      <div className="App">
        <header className="App-header">
          <img src={logo} className="App-logo" alt="logo" />
          <MyButton variant="contained" size="large"
            onClick={(event) => this.handleClick(event)} 
            onContextMenu={(event) => this.handleClick(event)} >
          * Do. Or do not. There is no try. *
          </MyButton>
        </header>
        <div className={this.state.shouldHide ? 'hidden' : 'App-Theme'} id="QuestionsContainer">
          <h2>{this.state.Q1_Question}</h2>
          <h3>{this.state.Q1_Ans}</h3>
          <h2>{this.state.Q2_Question}</h2>
          <h3>{this.state.Q2_Ans}</h3>
          <Question3 />
          <Question4 />
        </div>
      </div>
    );
  };
  handleClick = (e) => {
    e.preventDefault();
    if(this.state.shouldHide)
    {
      this.setState({ shouldHide: false});
      e.target.style.color = 'black';
    }
    else
    {
      this.setState({ shouldHide: true});
      e.target.style.color = '#D2691E';
    }
  }
  componentDidMount() {
    document.title = 'Dashboard';
    document.body.style.backgroundColor = "black";
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