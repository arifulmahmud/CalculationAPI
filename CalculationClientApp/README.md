This a sample client app for consuming Calculation API : [http://calcwebapi.azurewebsites.net/api/calc]. Project is bootstrapped with React [https://reactjs.org/]

### Setup the environment for running the application 
- Make sure you have a recent version of Node.js installed.<br />
- Copy the folder in your prefered location and open up a terminal window and `cd CalculationClientApp`.<br />
- In the project directory, you can run: Install required dependencies `npm install -all`.


### Run the application with `npm start`

- Runs the app in the development mode.<br />
- Open [http://localhost:3000] to view it in the browser.<br />
- const apiEndpoint is defined to live API endpoint running in Azure : [http://calcwebapi.azurewebsites.net/api/calc]. <br />
- Change `const apiEndpoint` in App.js to check the client app with local API endpoint. ie. `https://localhost:44364/api/calc`
- Provide number in the input field and select the action that you want to perform. Provide numbers in array ie. 2,3,4,5,6 for sum and check prime action. Just provide single number ie. 69 if the action is only check prime
### `npm run build`

- Builds the app for production to the `build` folder.<br />
- It correctly bundles React in production mode and optimizes the build for the best performance.<br />
- The build is minified and the filenames include the hashes.<br />
The app is ready to be deployed!

### `npm run eject`

**Note: this is a one-way operation. Once you `eject`, you can’t go back!**

If you aren’t satisfied with the build tool and configuration choices, you can `eject` at any time. This command will remove the single build dependency from your project.