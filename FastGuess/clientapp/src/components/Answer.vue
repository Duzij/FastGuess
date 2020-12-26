<template>
  <div>
    <span>
      <input type="checkbox" v-on:change="$emit('answer-selected', answer.answerText)">
      <strong>{{answer.answerText}}</strong>  
    </span>
  </div>
</template>

<script>
export default {
  props: { answer: { type: Object, required: true } },
};
</script>


<style>
</style>
