import React from 'react';
export default class List_Question_3 extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
        Question: "What species appeared in the most  number of Star Wars films? ",
        data: []
      };
    }

render() {
    const listItems = this.state.data.map((item) =>
        <h3>{item.name}    ({item.count}) </h3> 
    );
    return (<div className="App-Theme">
            <h2>{this.state.Question}</h2> 
            {listItems}
            </div>)
        }
    componentWillMount() {
     document.title = 'Dashboard';
     fetch("/api/GetSpeciesAppeared", {
      method: 'GET'
      })
      .then(res => res.json())
      .then((da) => {
        this.setState({ data: JSON.parse(da)})
     })
    }
  }