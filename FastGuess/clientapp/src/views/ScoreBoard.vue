<template>
  <div>
    <h1>ScoreBoard</h1>
    <table>
      <tr>
        <th>Nickname</th>
        <th>Date</th>
        <th>Score</th>
      </tr>
      <tr v-for="user in data.users" v-bind:key="user.nickname">
        <td>{{user.Nickname}}</td>
        <td>{{user.Date}}</td>
        <td>{{user.score}}</td>
      </tr>
    </table>
  </div>
</template>
