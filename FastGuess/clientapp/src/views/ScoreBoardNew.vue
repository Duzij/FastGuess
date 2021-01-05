<template>
  <div>
    <h2>Submit your score</h2>
    <hr/>
    <form @submit.prevent="submitScore" class="new_score_form">
      <label>Nickname</label>
      <input required type="text" v-model="nickname" />
      <button type="submit">Submit</button>
    </form>
  </div>
</template>
<script>
export default {
  data() {
    return {
      nickname: "",
    };
  },
  methods: {
    submitScore() {
      //pictures json
      var pictures = window.localStorage.getItem("pictures");

      const data = {
        nickname: this.nickname,
        answers: JSON.parse(pictures),
        date: null
      };

      console.log(data);

      fetch("http://localhost:5000/api/score", {
        method: "POST", // or 'PUT'
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify(data),
      })
        .then((response) =>  console.log(response))
        .then((data) => {
          console.log("Success:", data);
          this.$router.push("/score");
        })
        .catch((error) => {
          console.error("Error:", error);
        });
    },
  },
};
</script>

<style scoped>
.new_score_form {
  margin-top: 1rem;
}
</style>