export const Register = (userData) => {
  return fetch("https://localhost:44319/api/register/", {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(userData),
  }).then((data) => data.json())
};

export const signIn = (userData) => {
  return fetch("https://localhost:44319/api/login/", {
    method: "POST",
    headers: {
      "Content-Type": "application/json",
    },
    body: JSON.stringify(userData),
    
  }).then(data=>data.json())
};
