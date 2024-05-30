//$("form").on("submit", function (event) {
//    debugger

//    if ($('form')[0].checkValidity()) {
//        event.preventDefault();
//        console.log("hit")
//        let today = new Date(Date.now());
//        let eighteenYearBefore = new Date(new Date(today).getDate() + "/" + new Date(today).getMonth() + "/" + (new Date(today).getFullYear() - 18));
//        let userInputDate = new Date($("BirthDate").val());

//        if (userInputDate > eighteenYearBefore) {
//            $("#BirthDate")[0].setCustomValidity("");
//        } else {
//            $("#BirthDate")[0].setCustomValidity("invalid");
//            $("#BirthDate").append("<span class='text-danger'>The age should be greater than 18 year</span>")
//        }
//    }
//})



function updateUserRoles(target) {
    debugger
    let userId = $(target.parentElement.parentElement).find('td:first-child')[0].innerText;

    let updatedRoles = [];
    $(target.parentElement.parentElement).find("input[type=checkbox]:checked").each(function () {
        updatedRoles.push({
            userId: $(this).data('user-id'),
            roleId: $(this).data('role-id'),
            isChecked: true
        });
    });
    if (updatedRoles.length == 0) {
        fetch(`UpdateUserRolesDeleteRoles/${userId}`, {
            method: 'GET'
        }).then(function (reponse) {
            if (response.ok) {
                console.log('role update succesful');
                window.location.reload();
            }
        }).catch(function (err) {
            console.log(err);
        })
    } else {
        fetch('UpdateUserRoles', {
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(updatedRoles),
            method: 'POST'
        }).then(function (reponse) {
            if (response.ok) {
                console.log('role update succesful');
                window.location.reload();
            }
        }).catch(function (err) {
            console.log(err);
        })
    }
    
}


function updateRoleAccess(target) {
    let updatedRolesAccess = [];
    debugger

    let roleId = $(target.parentElement.parentElement).find('td:first-child')[0].innerText;
    $(target.parentElement.parentElement).find("input[type=checkbox]:checked").each(function () {
        updatedRolesAccess.push({
            roleId: $(this).data('role-id'),
            menuId: $(this).data('menu-id'),
            isChecked: true
        });
    });
    if (updatedRolesAccess.length == 0) {
        fetch(`UpdateRolesAccessDeleteAccess/${roleId}`, {
            method: 'GET'
        }).then(function (reponse) {
            if (response.ok) {
                console.log('role update succesful');
                window.location.reload();
            }
        }).catch(function (err) {
            console.log(err);
        })
    } else {
        fetch('UpdateRolesAccess', {
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(updatedRolesAccess),
            method: 'POST'
        }).then(function (reponse) {
            if (response.ok) {
                console.log('role update succesful');
                window.location.reload();
            }
        }).catch(function (err) {
            console.log(err);
        })
    }
}