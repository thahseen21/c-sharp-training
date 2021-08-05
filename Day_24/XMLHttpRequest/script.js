let data = [];

function FetchData() {
    const request = new XMLHttpRequest();

    // request.open("get", "https://catfact.ninja/fact?max_length=140", true);

    request.addEventListener('readystatechange', (e) => {
        if (e.target.readyState === 4) {
            const response = JSON.parse(e.target.responseText)
            this.data = response
            for (let employee of response.data) {
                AddElementToHTML(employee)
            }
        }
    })

    request.open('GET', 'https://reqres.in/api/users?page=1')
    request.send();
}

function AddElementToHTML(data) {
    let tag = `<div class="card-view" onclick="FetchUserDetail(${data.id})">
    <img src=${data.avatar} />
    <div class="details-wrapper">
      <p>${data.first_name}</p>
      <p>${data.email}</p>
    </div>
  </div>`;
    let container = document.getElementById('employee-containers');

    container.insertAdjacentHTML('beforeend', tag)
}

async function FetchUserDetail(data) {
    const response = await fetch(`https://reqres.in/api/users/${data}`, { method: 'get' });
    const parsedData = await response.json();
    if (response.status === 200) {
        ShowUserData(parsedData.data)
    }
}

function ShowUserData(data) {
    let tag = `<div class="backdrop" id="backdrop" onclick="CloseUserData(this)">
    <div class="pop-up">
      <img src="${data.avatar}" />
      <div class="details-wrapper">
        <p>${data.first_name}</p>
        <p>${data.email}</p>
      </div>
    </div>
  </div>`
    let container = document.getElementById('employee-containers');

    container.insertAdjacentHTML('beforeend', tag)
}

function CloseUserData(data) {
    data.remove()
}