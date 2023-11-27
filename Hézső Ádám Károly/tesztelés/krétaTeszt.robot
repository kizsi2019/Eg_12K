*** Settings ***
Library           Selenium2Library

*** Test Cases ***
teszt
    Open Browser    https://idp.e-kreta.hu/Account/Login?ReturnUrl=%2Fconnect%2Fauthorize%2Fcallback%3Fclient_id%3Dkreta-web%26response_type%3Dcode%26scope%3Dopenid%26state%3DOpenIdConnect.AuthenticationProperties%253D5Bq9TxNRlpTukZQL9Orq7pT0lkONwBAbeVFZIUMNBBRsrlMkCXSTcxyv2OJpS-jIh0sIAakJWn9kOQHPhZgir4M534xGxLxGV4f1wbBZ0Ed2jRQLIdgnENXOR0uO3X6q-QlrRZsfv4kTRFVqX-lx6A%26response_mode%3Dform_post%26nonce%3D638355512775004433.MTZjNTUwZDQtZWNiMC00NWQyLThiOTgtNDI1MmUzZjIxYjhiY2IwY2VjODctMGYyMi00YWEyLWFlNGUtNGQ5NGY1OTRlM2Fh%26institute_code%3Dbmszc-egressy%26institute_data%3DeyJuZXh0X3VwZGF0ZV9kYXRlX3RpbWUiOiIyMDIzLjExLjI4LiAyMjowMCIsImlzX3N6aXJfaW5zdGl0dXRlIjpmYWxzZSwiaXNfbGljZW5jZV92YWxpZCI6dHJ1ZSwiaXNfYXJjaGl2ZSI6ZmFsc2UsImlzX2Nzb2trZW50ZXR0X2dvbmR2aXNlbG8iOnRydWUsImlzX2ludGV6bWVueV9yb3ZpZG5ldiI6dHJ1ZSwiaXNfc3VjY2Vzc19hdXRob3JpemVkX2RhdGUiOmZhbHNlfQ%253D%253D%26prompt%3Dlogin%26redirect_uri%3Dhttps%253A%252F%252Fbmszc-egressy.e-kreta.hu%26x-client-SKU%3DID_NET461%26x-client-ver%3D5.3.0.0%26suppressed_prompt%3Dlogin    firefox
    Capture Page Screenshot
    Input Text    //*[@id="UserName"]    0
    Input Password    //*[@id="Password"]    0
    Click Button    //*[@id="submit-btn"]
    Wait Until Page Contains    203058/005 - Egressy
    Capture Page Screenshot
    Close Browser
