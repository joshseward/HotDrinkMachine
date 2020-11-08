import React, { Component } from 'react';

export class Home extends Component {
    static displayName = Home.name;

    async getDrink(drinkId: number) {
        const response = await fetch(`hotdrink/${drinkId}`);
        const data = await response.json();
        //this.setState({ forecasts: data, loading: false });
    }

  render () {
    return (
        <div>            
            <input type="button" value="Lemon Tea" onClick={() => this.getDrink(1) } />
            <input type="button" value="Coffee" onClick={() => this.getDrink(2)} />
            <input type="button" value="Chocolate" onClick={() => this.getDrink(3)} />
        <h2>Instructions</h2>
       </div>
    );
  }
}
