*** Settings ***
Library           Selenium2Library

*** Test Cases ***
login test
    Open Browser    https://accounts.google.com/InteractiveLogin/identifier?continue=https%3A%2F%2Fmail.google.com%2Fmail%2Fdata&emr=1&followup=https%3A%2F%2Fmail.google.com%2Fmail%2Fdata&osid=1&passive=1209600&service=mail&ifkv=ASKXGp3FZPaOZVXnWmn9uj2N6zpiPRduFURmgWioMT0uRheow3APfHfp0OXEFYUFfXPvnZn0Y0a_2w&theme=glif&flowName=GlifWebSignIn&flowEntry=ServiceLogin    chrome

    input text    //*[@id="identifierId"]    kovacs.tibor19k@egressy.info
    click button    //*[@id="identifierNext"]/div/button
    wait until page does not contain element    //*[@id="identifierNext"]/div/button

    input text    //*[@id="password"]/div[1]/div/div[1]/input    Pyro2016

    click button    //*[@id="passwordNext"]/div/button
    wait until page contains element    /html/body/div[8]/div[3]/div/div[2]/div[2]/div[1]/div[1]/div/div

    click element    /html/body/div[8]/div[3]/div/div[2]/div[2]/div[1]/div[1]/div/div

teszt2
