import React, { Component } from "react";
import "./App.css";
// import SplashPage from './Pages/Splash'
import HomePage from "./Pages/Home";
import Location from "./Pages/Location";
import {
  BrowserRouter as Router,
  Route,
  Switch,
} from "react-router-dom";

class App extends Component {
  state = {
    redirect: false
  };

  handleSearchTermUpdate = e => {
    this.setState({ searchTerm: e.target.value });
  };
  handleSearch = e => {
    e.preventDefault();
    if (this.state.searchTerm){
      window.location.replace(`/search/${this.state.searchTerm}`);
    } else {
      window.location.replace(`/`);

    }
  };

  render() {
    return (
      <Router>
        <>
          <nav
            className="navbar is-dark"
            role="navigation"
            aria-label="main navigation"
          >
            <div className="navbar-brand">
              <a className="navbar-item" href="/">
                Coffee Ship, Sail the Java Seas.
              </a>
            </div>

            {/* <div id="navbarBasicExample" className="navbar-menu">


                    </div> */}

            {/* <div className="navbar-end">
                        <div className="navbar-item">
                            <div className="buttons">
                                <a className="button is-primary">
                                    <strong>Sign up</strong>
                                </a>
                                <a className="button is-light">
                                    Log in
                               </a>
                            </div>
                        </div>
                    </div> */}
          </nav>
          <form onSubmit={this.handleSearch} className="search-form">
            <div className="field has-addons">
              <div className="control">
                <input
                  onChange={this.handleSearchTermUpdate}
                  className="input"
                  type="text"
                  placeholder="Find a coffee harbor"
                />
              </div>
              <div className="control">
                <button type="submit" className="button is-info">Search</button>
              </div>
              <div className="control">
                <button className="button is-primary" >Near me</button>
              </div>
            </div>
          </form>

          <Switch>
            <Route path="/" exact component={HomePage} />
            <Route path="/location/:id" exact component={Location} />
            <Route path="/search/:searchterm" exact component={HomePage} />
            {/* <Route path="/home" exact component={HomePage}/> */}
          </Switch>
        </>
      </Router>
    );
  }
}

export default App;
