let data = [];

function FetchData() {
    const request = new XMLHttpRequest();

    // request.open("get", "https://catfact.ninja/fact?max_length=140", true);

    request.addEventListener('readystatechange', (e) => {
        if (e.target.readyState === 4) {
            const response = JSON.parse(e.target.responseText)
            console.log(data.data)
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
    console.log(data)
    let tag = `<div class="card-view">
    <img src=${data.avatar} />
    <div class="details-wrapper">
      <p>${data.first_name}</p>
      <p>${data.email}</p>
    </div>
  </div>`;
    let container = document.getElementById('employee-containers');

    container.insertAdjacentHTML('beforeend', tag)

}