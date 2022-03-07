import { useAuth0 } from "@auth0/auth0-react";
import { Button } from "antd";

export function LoginButton() {
    const { loginWithRedirect } = useAuth0();

    return (
        <Button type="primary" onClick={() => loginWithRedirect()}>
            Log In
        </Button>
    );
}
