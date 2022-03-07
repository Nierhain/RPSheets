import { useEffect, useState } from "react";
import logo from "./logo.svg";
import "./App.css";
import { LoginButton } from "./components/LoginButton";
import { Layout } from "antd";
import { LogoutButton } from "./components/LogoutButton";
const { Header, Content, Sider } = Layout;

import {useAuth0} from '@auth0/auth0-react'
import { UserAPI } from "./api/api";
 
function App() {
    const [count, setCount] = useState(0);
    const { user, isAuthenticated, getAccessTokenSilently} = useAuth0()

    useEffect(() => {
        if (isAuthenticated) {
            UserAPI.login(getAccessTokenSilently)
        }
    }, [getAccessTokenSilently, user?.sub])

    return (
        <Layout>
            <Header>
          <LoginButton />
          <LogoutButton />
            </Header>
            <Sider></Sider>
            <Content>
                {isAuthenticated && (
                    <div>
                        <h2>{console.log(user?.sub)} {"tabled"}</h2>
                    </div>
                )}
            </Content>
        </Layout>
    );
}

export default App;
