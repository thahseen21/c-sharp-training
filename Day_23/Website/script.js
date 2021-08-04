let studentList = [{ fullName: "asdf", gender: "male", dob: "2021-08-04", address: "asdfasdf" }, { fullName: "asdf", gender: "male", dob: "2021-08-04", address: "asdfasdf" }];

class StudentDetail {
    constructor(fullName, isMale, dob, address) {
        this.fullName = fullName
        this.gender = isMale ? 'male' : 'female'
        this.dob = dob
        this.address = address
    }
}
function GetDetails() {
    const fullName = document.getElementById("fullName").value;

    const isMale = document.getElementById("gender").checked;

    const dob = document.getElementById("dob").value;

    const address = document.getElementById('address').value

    const temp = new StudentDetail(fullName, isMale, dob, address);

    if (temp) {
        studentList.push(temp)
        alert('Student has been added')
    }
    localStorage.setItem('studentlist', JSON.stringify(studentList))
}

function DisplayStudents() {
    const displayStudentTag = document.getElementById("student")
    let countRef = 0;
    for (let student of studentList) {
        let tag = ` <div>
        <h1>Student ${++countRef}</h1>
        <h4>FullName : ${student.fullName}</h4>
        <h4>Gender : ${student.gender}</h4>
        <h4>DOB : ${student.dob}</h4>
        <h4>Address : ${student.address}</h4>
      </div>`
        displayStudentTag.insertAdjacentHTML("afterbegin", tag)
    }
}