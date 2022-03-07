import React from "react";
import ReactDOM from "react-dom";
import "./index.css";
import "antd/dist/antd.dark.min.css"
import App from "./App";
import { Auth0Provider } from "@auth0/auth0-react";

ReactDOM.render(
    <React.StrictMode>
        <Auth0Provider
            domain="rpsheets.eu.auth0.com"
            clientId="2t2Ul5wJxZeti03LjFkNwcTva48Oc7cH"
            redirectUri={window.location.origin}
            audience="api"
            scope="Admin Gamemaster Player"
            useRefreshTokens={true}>
            <App />
        </Auth0Provider>
    </React.StrictMode>,
    document.getElementById("root")
);
