import React from "react";
import axios from "axios";
import "./App.css";

class App extends React.Component {
  constructor(props) {
    super(props);
    this.state = { responseText: "" };
  }

  handleSubmit = (event) => {
    event.preventDefault();
    console.log('Given Input is: ' + this.numberNode.value + ' action:' + this.actionNode.value);
    // service is hosted in Azure web app
    const apiEndpoint = 'http://calcwebapi.azurewebsites.net/api/calc?action=' + this.actionNode.value + '&numbers=' + this.numberNode.value;
    axios.get(apiEndpoint)
      .then((res) => {
        // print response if the status is OK (200) or print the error
        if (res.statusText === "OK") {
          console.log(res.data);
          this.setState({ responseText: 'Response from the server: ' + JSON.stringify(res.data) });
        }
        else {
          this.setState({ responseText: 'Something went wrong' });
        }
      })
      .catch((err) => {
        // then print response status
        this.setState({ responseText: err.message });
        console.log(err.data);
      });
  }

  render() {
    return (
      <div class="container">
        <div class="row">
          <div class="col-md-6 offset-md-3 col-sm-offset-1">
            <div class="form-group">
              <label>Numbers (single number for Prime check)</label>
              <input type="text" name="number" class="form-control" ref={node => (this.numberNode = node)} />
            </div>
            <div class="form-group">
              <label>Action</label>
              <select id="action" name="action" class="form-control" ref={node => (this.actionNode = node)}>
                <option value="sumandcheck">Sum and Check Prime</option>
                <option value="checkprime">Check Prime</option>
              </select>
            </div>
            <p class="output">{this.state.responseText}</p>
            <input type="submit" value="Submit" class="form-control btn btn-success" onClick={this.handleSubmit} />
          </div>
        </div>
      </div >
    );
  }
}
export default App;