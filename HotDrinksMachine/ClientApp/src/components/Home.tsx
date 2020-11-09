import React, { Component, useState } from 'react';
import { Container, Row, Col } from 'reactstrap';
import { HotDrinks } from '../types/hotDrink'

const Home = () => {

  const intitalValues: string[] = []
  const [actions, setActions] = useState(intitalValues);

    const displayName = Home.name;

    const getDrink = async (drinkId: number)  => {
        const response = await fetch(`hotdrink/${drinkId}`);
        const data = await response.json();
        setActions(data)
    }

    return (
        <div>
          <Container>      
            <Row>
              <Col md={{ size: 4}}>
                <input type="button" value="Lemon Tea" onClick={() => getDrink(HotDrinks.LemonTea) } />
              </Col>
              <Col md={{ size: 4}}>
                <input type="button" value="Coffee" onClick={() => getDrink(HotDrinks.Coffee)} />
              </Col>
              <Col md={{ size: 4}}>
                <input type="button" value="Chocolate" onClick={() => getDrink(HotDrinks.Chocolate)} />
              </Col>
            </Row>
            <hr />
            <Row>
              <Col md={{ size: 4, offset: 4 }}>
                <h2>Actions</h2>
              </Col>
            </Row>
            <Row>
              <Col md={{ size: 5, offset: 4 }}>
                <ul>
                  {actions.map(x => (
                    <li>{x}</li>
                  ))}
                </ul>
              </Col>
            </Row>
          </Container>
       </div>
    );
}

export default Home
