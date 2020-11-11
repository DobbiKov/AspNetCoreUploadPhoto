import React, { useState } from 'react';

export const Home = () => {
  const [file, setFile] = useState(null);

  const changeFileHandler = event => {
    console.log(event.target.files[0]);
    
  }

  const uploadPhotoHandler = async event => {
    let fd = new FormData();
    fd.append('formFile', event.target.files[0]);
    fd.append('fileName', event.target.files[0].name);
    const req = await fetch('/api/Upload/Upload', {method: 'POST', body: fd});
    const data = req.json();
    console.log(data);
  }

  return (
    <div>
      Choose file:
      <input type="file" onChange={uploadPhotoHandler} />
      <button>Upload Photo</button>
      <img src="https://localhost:44322/Resources/Images/ins.png" />
    </div>
  );
}
