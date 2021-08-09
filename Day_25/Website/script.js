$(document).ready(function() {
    let errors = {
        name: true,
        gender: true,
        dob: true,
        address: true,
    };
    $("#fullNameCheck").hide();
    $("#dobCheck").hide();
    $("#genderCheck").hide();
    $("#addressCheck").hide();

    $("#fullName").keyup(() => {
        validateFullName();
    });

    function validateFullName() {
        let fullName = $("#fullName").val();
        if (fullName.length == "") {
            $("#fullNameCheck").show();
            errors.name = true;
        } else {
            $("#fullNameCheck").hide();
            errors.name = false;
        }
    }

    $("#gender").change(() => {
        validateGender();
    });

    function validateGender() {
        errors.gender = false;
        $("#genderCheck").hide();
    }

    $("#dob").on("keyup change", () => {
        validateDOB();
    });

    function validateDOB() {
        let dob = $("#dob").val();
        if (dob) {
            errors.dob = false;
            $("#dobCheck").hide();
        } else {
            errors.dob = true;
            $("#dobCheck").show();
        }
    }

    $("#address").keyup(() => {
        validateAddress();
    });

    function validateAddress() {
        let addressValue = $("#address").val();
        if (addressValue.length > 20) {
            errors.address = false;
            $("#addressCheck").hide();
        } else {
            $("#addressCheck").show();
        }
    }

    $("#form").submit(function(e) {
        e.preventDefault();
        console.log("message");
        if (!errors.name && !errors.dob && !errors.gender && !errors.address) {
            console.log("no erros");
            GetDetails();
        } else {
            if (errors.name) {
                $("#fullNameCheck").show();
            }
            if (errors.dob) {
                $("#dobCheck").show();
            }
            if (errors.gender) {
                $("#genderCheck").show();
            }
            if (errors.address) {
                $("#addressCheck").show();
            }
        }
    });
});

let studentList = [
    { fullName: "asdf", gender: "male", dob: "2021-08-04", address: "asdfasdf" },
    { fullName: "asdf", gender: "male", dob: "2021-08-04", address: "asdfasdf" },
];

class StudentDetail {
    constructor(fullName, isMale, dob, address) {
        this.fullName = fullName;
        this.gender = isMale ? "male" : "female";
        this.dob = dob;
        this.address = address;
    }
}

function GetDetails() {
    const fullName = document.getElementById("fullName").value;

    const isMale = document.getElementById("gender").checked;

    const dob = document.getElementById("dob").value;

    const address = document.getElementById("address").value;

    const temp = new StudentDetail(fullName, isMale, dob, address);

    if (temp) {
        studentList.push(temp);
        alert("Student has been added");
    }
    localStorage.setItem("studentlist", JSON.stringify(studentList));
}

function DisplayStudents() {
    const displayStudentTag = document.getElementById("student");
    let countRef = 0;
    for (let student of studentList) {
        let tag = ` <div>
        <h1>Student ${++countRef}</h1>
        <h4>FullName : ${student.fullName}</h4>
        <h4>Gender : ${student.gender}</h4>
        <h4>DOB : ${student.dob}</h4>
        <h4>Address : ${student.address}</h4>
      </div>`;
        displayStudentTag.insertAdjacentHTML("afterbegin", tag);
    }
}