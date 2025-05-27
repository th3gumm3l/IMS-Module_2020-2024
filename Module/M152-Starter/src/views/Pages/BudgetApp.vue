<script setup>
import { ref } from "vue";

const logs = ref([
    {
        id: 1,
        text: 'Startsaldo',
        value: 1500
    },
    {
        id: 2,
        text: 'Bus-Abo',
        value: -79
    },
    {
        id: 3,
        text: 'Essen',
        value: -50
    },
    {
        id: 4,
        text: 'Auto tanken',
        value: -80
    },
    {
        id: 5,
        text: 'Lohn',
        value: +800
    },
    {
        id: 6,
        text: 'Neuer Laptop',
        value: -1000
    },
])

const currentId = ref(6)
const newText = ref();
const newValue = ref();

//Function to add own input
function addLog() {
    const newElement = {
        id: currentId.value,
        text: newText.value,
        value: parseFloat(newValue.value)
    }
    currentId.value++
    logs.value.push(newElement);
}

//Function to delete an element in list
function deleteLog(id){
    logs.value = logs.value.filter((element)=> {
        return element.id !== id;
    })
}

</script>

<template>
    <h1>Budget App</h1>

    <table>
        <tr>
            <th>Bezeichnung</th>
            <th>Betrag</th>
        </tr>
        <tr v-for="log in logs">
            <td>{{ log.text }}</td>
            <td :class="log.value > 0 ? 'text-green' : 'text-red'">{{ log.value }}</td>
            <td>
                <button @click="deleteLog(log.id)">X</button>
            </td>
        </tr>
    </table>

    <h1>Neuer Eintrag erfassen</h1>
    <label for="text">Bezeichnung des Kaufs</label>
    <input type="text" id="text"  v-model="newText">
    <label for="">Kaufbetrag</label>
    <input type="number" v-model="newValue">
    <button @click="addLog" type="submit">Hinzufügen</button>
  
</template>

<style lang="scss">
  .text-green {
    background-color: green;
    color: white;
  }
  .text-red {
    background-color: red;
    color: white;
  }
  table {
    border-collapse: collapse;
    width: 50%;
  }

  th, td {
    padding: 8px;
    text-align: left;
    border-bottom: 1px solid #ddd;
  }

  th {
    background-color: #f2f2f2;
  }

  tr:nth-child(even) {
    background-color: #f2f2f2;
  }
</style>