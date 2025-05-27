<template>
    <form action="/" method="post">
        <div class="namesOfUser">
            <label for="username">Username</label>
            <input type="text" name="username" id="username">
            <label for="firstname">Firstname</label>
            <input type="text" name="firstname" id="firstname">
            <label for="lastname">Lastname</label>
            <input type="text" name="lastname" id="lastname">
        </div>
        <div class="loginData">
            <label for="email">E-Mail</label>
            <input type="email" name="email" id="email">
            <label for="password">Password</label>
            <input type="password" name="password" id="password">
        </div>
        <div class="locationOfUser">
            <label for="street">Street</label>
            <input type="text" name="street" id="street">
            <label for="postalCode">Postal Code</label>
            <input type="text" name="postalCode" id="postalCode">
            <label for="city">City</label>
            <input type="text" name="city" id="city">
        </div>
        <div class="lehrjahr">
            <label for="lehrjahr">Lehrjahr</label>
            <label for="lehrjahr1"></label>
            <input type="radio" name="lehrjahr1" id="lehrjahr1">
            <label for="lehrjahr2"></label>
            <input type="radio" name="lehrjahr2" id="lehrjahr2">
            <label for="lehrjahr3"></label>
            <input type="radio" name="lehrjahr3" id="lehrjahr3">
        </div>
        <button type="submit">
            Submit
        </button>
    </form>
</template>

<style>
    /* Form container */
    form {
        display: flex;
        flex-direction: column;
        align-items: center;
        justify-content: center;
        margin: 50px auto;
        width: 50%;
        padding: 20px;
        background-color: #f2f2f2;
        border-radius: 5px;
    }

    /* Form input labels */
    label {
        display: block;
        font-weight: bold;
        margin-top: 10px;
    }

    /* Form input fields */
    input[type="text"],
    input[type="email"],
    input[type="password"] {
        width: 100%;
        padding: 10px;
        margin-top: 5px;
        margin-bottom: 10px;
        border-radius: 5px;
        border: 1px solid #ccc;
    }

    /* Radio button label */
    .lehrjahr label {
        margin-right: 10px;
    }

    /* Form submit button */
    button[type="submit"] {
        background-color: #4CAF50;
        color: #fff;
        padding: 10px 20px;
        border: none;
        border-radius: 5px;
        cursor: pointer;
        margin-top: 20px;
    }

    /* Form submit button on hover */
    button[type="submit"]:hover {
        background-color: #45a049;
    }

</style>