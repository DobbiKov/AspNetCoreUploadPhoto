# Upload photo with ASP NET CORE Web API

Developer: [Roman Zapotockiy](https://t.me/dobbi_crmp) (dobbikov)

Upload files to server with ASP NET Core web api.

## Stack
- BackEnd
  - ASP NET Core
- FrontEnd
  - React JS
  
## Setup
1. Install
  - [.NET Core SDK](https://docs.microsoft.com/ru-ru/aspnet/core/?view=aspnetcore-5.0)
  - [Node JS](https://nodejs.org/)
  - [React JS](https://reactjs.org) - `npm install react-app`
2. Write to cmd: `npm install`
3. Start .NET Project

## Usage
Upload photo with http rest api `http://domain/api/Upload/Upload`

Example:<br/>
```javascript
  const uploadPhotoHandler = async event => {
    let fd = new FormData();
    fd.append('formFile', event.target.files[0]);
    fd.append('fileName', event.target.files[0].name);
    const req = await fetch('/api/Upload/Upload', {method: 'POST', body: fd});
    const data = req.json();
  }
```
