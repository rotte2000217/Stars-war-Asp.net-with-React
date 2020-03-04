import React from 'react';
export default class List_Question_4 extends React.Component {
  constructor(props) {
    super(props);
    this.state = {
        Question: "What planet in Star Wars universe provided largest number of vehicle pilots?",
        data: []
      };
    }

render() {
    const listItems = this.state.data.map((item) =>
        <h3>Planet: {item.name} - Pilots: ({item.count}) {item.pilots}</h3> 
    );
    return (<div className="App-Theme">
            <h2>{this.state.Question}</h2> 
            {listItems}
            </div>)
        }
     componentDidMount() {
     document.title = 'Dashboard';
     fetch("/api/GetVehiclePilots", {
      method: 'GET'
      })
      .then(res => res.json())
      .then((da) => {
        this.setState({ data: JSON.parse(da)})
     })
    }
  }