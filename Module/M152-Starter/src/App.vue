<script setup>
import { RouterLink, RouterView } from 'vue-router'
</script>

<template>
  <header>
    <nav>
        <RouterLink to="/">Home</RouterLink>
        <RouterLink to="/aufgabe12-2">Aufgabe 12.2</RouterLink>
        <RouterLink to="/ichweissnidwasdasisch">ichweissnidwasdasisch</RouterLink>
        <RouterLink to="/dialogForm">DialogForm</RouterLink>
        <RouterLink to="/budgetapp">Budget App</RouterLink>
    </nav>
  </header>

  <RouterView />
</template>

<style scoped>
nav {
  display: flex;
  justify-content: center;
  padding: 20px 0px;
  background-color: aqua;
}

nav a {
  display: block;
  color: black;
  text-decoration: none;
  margin: 0 10px;
  font-size: 1.5rem;
}
nav a:hover {
  color: green;
}
</style>
