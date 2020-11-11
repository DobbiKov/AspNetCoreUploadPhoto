import React from 'react';
import { Route } from 'react-router-dom';
import { Container } from 'reactstrap';

import { Home } from './pages/Home';
import { FetchData } from './pages/FetchData';
import { Counter } from './pages/Counter';

export const useRoutes = () => {
    return(
        <Container>
            <Route exact path='/' component={Home} />
            <Route path='/counter' component={Counter} />
            <Route path='/fetch-data' component={FetchData} />
        </Container>
    )
}