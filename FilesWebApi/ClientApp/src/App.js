import React, { Component } from 'react';
import { Route } from 'react-router';
import Layout from './components/Layout';
import { useRoutes } from './routers';


import './custom.css'

const App = () => {
  return (
    <Layout>
      {useRoutes()}
    </Layout>
  );
}

export default App;